using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            //IEnumerable<Vehicle> seedVehicles = GetSeedData();
            //modelBuilder.Entity<Vehicle>().HasData(seedVehicles);
        }

        private IEnumerable<Vehicle> GetSeedData()
        {
            var list = new List<Vehicle>();
            for (int i = 1; i < 20; i++)
            {
                var make = GetRandomMake();
                var model = GetRandomModel();
                var v = new Vehicle
                {
                    Id = i,
                    Make = make,
                    Model = model,
                    LicenseNumber = GetRandomLicenseNumber(make, model, i)
                };

                list.Add(v);
            }

            return list;
        }

        private string GetRandomLicenseNumber(string make, string model, int id)
        {
            string str = make.Substring(0, 3);
            Random rnd = new Random();
            int num = rnd.Next(100, 999);
            return $"{str.ToUpper()}{num}";
        }

        private string GetRandomModel()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, _models.Count());
            return _models[num];
        }

        private string GetRandomMake()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, _makes.Count());
            return _makes[num];
        }

        private List<string> _makes => new List<string> { "Volvo", "Saab", "Opel", "Volkswagen", "Mazda", "BMW", "Lexus", "Kia", "Ford" };
        private List<string> _models => new List<string> { "XC90", "V90", "XC60", "C30", "740", "900", "9000", "9-3", "Ascona", "Kadett", "Passat", "Golf", "Polo", "Up", "Touareg", "M5", "M3", "i8", "Ceed", "Rio", "Focus", "Mondeo", "Egde", "Fiesta" };

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
