﻿using Microsoft.Extensions.Caching.Memory;
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
        public VehicleRepository(ApplicationDbContext ctx, IMemoryCache c)
        {
            context = ctx;
            cache = c;

        }

        public IEnumerable<Vehicle> GetAll()
        {
            IEnumerable<Vehicle> vehicles;

            if (!cache.TryGetValue(CacheKeys.Vehicles, out vehicles))
            {
                //Didn't find a key with value "_CachedVehicles" in cache. 
                //Get vehicles from db and order it by Id, highest first.

                //Simulate heavy/time consuming operation
                Thread.Sleep(4000);

                vehicles = context.Vehicles.OrderByDescending(x => x.Id).ToList();

                //Set cache options based on how we want it to be caches
                var options = new MemoryCacheEntryOptions();
                options.SetSlidingExpiration(TimeSpan.FromSeconds(20));

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
    }
}
