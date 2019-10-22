using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;
using System.Collections.Generic;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var vehicle = new VehicleViewModel { Make = "Volvo", Model = "V90" };

            var vm = new HomeViewModel
            {
                Name = "Kalle Kula",
                Age = 30,
                Vehicle = vehicle,
                Values = GetValues()
            };


            return View(vm);
        }

        private Dictionary<int, string> GetValues()
        {
            var dic = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, "Five" }
            };

            return dic;
        }

        public IActionResult SubmitForm(string selectedIds)
        {
            if (!string.IsNullOrEmpty(selectedIds))
            {
                var ids = selectedIds.Split(',');
            }
            return RedirectToAction(nameof(Index));
        }
    }
}