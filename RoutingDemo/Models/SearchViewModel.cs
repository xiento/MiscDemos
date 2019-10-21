using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Models
{
    public class SearchViewModel
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public IEnumerable<Vehicle> Results { get; set; }
    }
}
