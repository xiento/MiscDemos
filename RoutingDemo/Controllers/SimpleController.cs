using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Controllers
{
    public class SimpleController : Controller
    {
        public IActionResult Index()
        {
            return base.View();
        }
    }
}
