using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Components
{
    public class VehicleInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var vm = new VehicleViewModel
            {
                Make = "Volvo",
                Model = "XC90 T8"
            };
            return View(vm);
        }
    }
}
