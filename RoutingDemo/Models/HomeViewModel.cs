using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Models
{
    public class HomeViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public VehicleViewModel Vehicle { get; set; }
        public Dictionary<int, string> Values { get; set; }
    }
}
