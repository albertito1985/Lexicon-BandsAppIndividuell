using BandsApp.Web.Models;
using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Contorllers
{
    public class BandController: Controller
    {
        static BandService service = new BandService();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        [HttpPost("/Add")]
        public IActionResult AddBand(Band newBand)
        {
            service.AddBand(newBand);
            return View(nameof(Index));
        }
    }
}
