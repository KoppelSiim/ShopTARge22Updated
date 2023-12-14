using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ShopTARge22.Controllers
{
    public class ErrorController : Controller
    {

        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }


        public IActionResult HttpStatusErrorCodeHandler(int statuscode)
        {

            var statusCodeResult = HttpContext.Features.Get<IStatusCodeActionResult>();

            switch (statusCodeResult)
            {

               // case 404:

            }

            return View("NotFound");
        }


        /* [Route("Error")]
         AllowAn*/


       /* [Route("Error")]
        [AllowAnonymous]

        public IActionResult Error()
        {

        }
        */
    }
}
