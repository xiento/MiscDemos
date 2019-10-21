using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Models
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
        Task<Vehicle> Create(Vehicle v);
        IEnumerable<Vehicle> Search(SearchViewModel vm);
    }
}
