using Microsoft.AspNetCore.Mvc;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Data;
using ShopTARge22.Models.Realestates;
using ShopTARge22.Models.Spaceships;

namespace ShopTARge22.Controllers
{
    public class RealestatesController : Controller
    {
        private readonly ShopTARge22Context _context;
        private readonly IRealestatesServices _realestatesServices;

        public RealestatesController(ShopTARge22Context context, IRealestatesServices realestatesServices )
        {
            _context = context;
            _realestatesServices = realestatesServices;
        }
        public IActionResult Index()
        {
            var result = _context.Realestates
                .Select(x => new RealestatesIndexViewModel
                {
                    Id = x.Id,
                    Address = x.Address,
                    SizeSqrM = x.SizeSqrM,
                    RoomCount = x.RoomCount,
                    Floor = x.Floor,
                    BuildingType = x.BuildingType,
                    BuiltInYear = x.BuiltInYear
                });

            return View(result);
        }
    }
}
