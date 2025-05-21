using BandsApp.Web.Models;
using BandsApp.Web.Services;
using BandsApp.Web.Views.Bands;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Contorllers
{
    public class BandsController (BandService service) : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetAll();
            var viewModel = new IndexVM { Bands = [.. model.Select(b => new IndexVM.BandItemVM { Name = b.Name })] };
            
            return View(viewModel);
        }

        [HttpGet("/Add")]
        public IActionResult AddBand()
        {
                return View();
        }

        [HttpPost("/Add")]
        public IActionResult AddBand(AddBandVM newBandVM)
        {
            if (!ModelState.IsValid)
                return View();

            Band newBand = new Band { Name= newBandVM.Name };
            service.AddBand(newBand);
            return RedirectToAction(nameof(Index));
        }




        
    }
}
