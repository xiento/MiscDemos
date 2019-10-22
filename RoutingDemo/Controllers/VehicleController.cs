using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Infrastructure;
using RoutingDemo.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingDemo.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository repo;
        private readonly IRazorViewToHtmlHelper razorViewToHtmlHelper;

        public VehicleController(IVehicleRepository repo, IRazorViewToHtmlHelper razorViewToHtmlHelper)
        {
            this.repo = repo;
            this.razorViewToHtmlHelper = razorViewToHtmlHelper;
        }
        public IActionResult Index()
        {
            var vehicles = repo.GetAll();
            return View(vehicles);
        }

        public async Task<IActionResult> Create(Vehicle v)
        {
            if (ModelState.IsValid)
            {
                var createdVehicle = await repo.Create(v);
                var emailBody = await razorViewToHtmlHelper.RenderViewToStringAsync("/Views/Shared/EmailTemplates/VehicleCreatedEmailTemplate.cshtml", v);
                var emailResult = await MailSender.Send(emailBody);
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Index), null);
        }
    }
}