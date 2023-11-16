using Microsoft.AspNetCore.Mvc;
using ShopTARge22.Core.Dto.AccuWeatherDtos;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Models.AccuWeatherForecast;
using ShopTARge22.Models.AccuWeathers;

namespace ShopTARge22.Controllers
{
    public class AccuWeathersController : Controller
    {
        private readonly IAccuWeatherServices _accuWeatherServices;
        public AccuWeathersController(IAccuWeatherServices accuWeatherServices)
        {
            _accuWeatherServices = accuWeatherServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchCity(SearchCityViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Weather", "AccuWeathers", new { city = model.CityName });
            }
            return View(model);
        }

       
        [HttpGet]
        public IActionResult Weather(string city)
        {
            AccuWeatherResponseRootDto dto = new();
            dto.City = city;
             _accuWeatherServices.GetWeatherInfo(dto);
            AccuWeatherViewModel vm = new();
            return View(vm);
        }
         
    }
}
