using Microsoft.AspNetCore.Mvc;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Data;

namespace ShopTARge22.Controllers
{
    public class KindegartensController : Controller
    {
        private readonly ShopTARge22Context _context;
        private readonly IKindergartenServices _kindergartenServices;

        public KindegartensController(ShopTARge22Context context, IKindergartenServices kindergartenServices)
        {
            _context = context;
            _kindergartenServices = kindergartenServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
