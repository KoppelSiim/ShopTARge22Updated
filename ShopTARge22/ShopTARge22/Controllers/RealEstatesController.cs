using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopTARge22.Core.Domain;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Data;
using ShopTARge22.Models.Realestates;


namespace ShopTARge22.Controllers
{
    public class RealestatesController : Controller
    {
        private readonly ShopTARge22Context _context;
        private readonly IRealestateServices _realestateServices;

        public RealestatesController(ShopTARge22Context context, IRealestateServices realestatesServices)
        {
            _context = context;
            _realestateServices = realestatesServices;
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

        /*{ public async Task<Realestate> DetailsAsync(Guid id)

             var result = await _context.Realestates
                 .FirstOrDefaultAsync(x => x.Id == id);

             return result;
         }*/
    }
}
