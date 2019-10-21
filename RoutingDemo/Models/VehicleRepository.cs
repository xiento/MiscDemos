using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RoutingDemo.Models
{
    public class CacheKeys
    {
        public static readonly string Vehicles = "_CachedVehicles";
    }
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMemoryCache cache;
        private readonly IConfiguration config;
        public VehicleRepository(ApplicationDbContext ctx, IMemoryCache c, IConfiguration configuration)
        {
            context = ctx;
            cache = c;
            config = configuration;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            IEnumerable<Vehicle> vehicles;

            if (!cache.TryGetValue(CacheKeys.Vehicles, out vehicles))
            {
                //Didn't find a key with value "_CachedVehicles" in cache. 
                //Get vehicles from db and order it by Id, highest first.

                //Simulate heavy/time consuming operation if set to true in appsettings
                bool simulateHeavyOperation = config.GetSection("Settings").GetValue<bool>("SimulateTimeConsumingDbOperation");
                if (simulateHeavyOperation)
                    Thread.Sleep(4000);

                vehicles = context.Vehicles.OrderByDescending(x => x.Id).ToList();

                //Set cache options based on how we want it to be caches
                var options = new MemoryCacheEntryOptions();
                var seconds = config.GetSection("Settings").GetValue<int>("CacheSlidingExpirationInSeconds");
                options.SetSlidingExpiration(TimeSpan.FromSeconds(seconds));

                //Place the list of vehicles in cache with cache key "_CachedVehicles"
                //Sliding expiration of 10 seconds
                cache.Set(CacheKeys.Vehicles, vehicles, options);
            }

            return vehicles;
        }

        public async Task<Vehicle> Create(Vehicle v)
        {
            try
            {
                await context.Vehicles.AddAsync(v);
                await context.SaveChangesAsync();

                //Remove vehicles from the cache and force a new cache when requested.
                cache.Remove(CacheKeys.Vehicles);
                return v;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Vehicle> Search(SearchViewModel vm)
        {
            var results = GetAll();
            if (!string.IsNullOrEmpty(vm.Make))
                results = results.Where(x => x.Make.Contains(vm.Make, StringComparison.InvariantCultureIgnoreCase));
            if(!string.IsNullOrEmpty(vm.Model))
                results = results.Where(x => x.Model.Contains(vm.Model, StringComparison.InvariantCultureIgnoreCase));
            if(!string.IsNullOrEmpty(vm.LicenseNumber))
                results = results.Where(x => x.LicenseNumber.Contains(vm.LicenseNumber, StringComparison.InvariantCultureIgnoreCase));

            return results;
        }
    }
}
