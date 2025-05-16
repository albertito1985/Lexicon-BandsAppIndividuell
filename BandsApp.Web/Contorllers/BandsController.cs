using BandsApp.Web.Models;
using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Contorllers
{
    public class BandsController: Controller
    {
        static BandService service = new BandService();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        [HttpGet("/Add")]
        public IActionResult AddBand()
        {
                return View();
        }

        [HttpPost("/Add")]
        public IActionResult AddBand(Band newBand)
        {
            if (!ModelState.IsValid)
                return View();

            service.AddBand(newBand);
            return RedirectToAction(nameof(Index));
        }




        
    }
}
