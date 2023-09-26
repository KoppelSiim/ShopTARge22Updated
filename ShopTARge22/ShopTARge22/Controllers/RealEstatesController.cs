using Microsoft.AspNetCore.Mvc;
using ShopTARge22.Data;

namespace ShopTARge22.Controllers
{
    public class RealestatesController : Controller
    {
        private readonly ShopTARge22Context _context;

        public RealestatesController(ShopTARge22Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
