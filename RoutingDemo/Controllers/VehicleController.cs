using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository repo;

        public VehicleController(IVehicleRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int take = 10, int skip = 0)
        {
            var vehicles = repo.GetAll().Skip(skip).Take(take);
            if (HttpContext.Request.Method == "GET")
                return View(vehicles);
            return Json(vehicles);
        }

        public async Task<IActionResult> Create(Vehicle v)
        {
            if (ModelState.IsValid)
            {
                var createdVehicle = await repo.Create(v);
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Index), null);
        }
    }
}