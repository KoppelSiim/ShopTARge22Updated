using Microsoft.AspNetCore.Mvc;

namespace ShopTARge22.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult HttpStatusErrorCodeHandler(int statuscode)
        {
            return View();
        }
    }
}
