using Microsoft.AspNetCore.Mvc;
using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Models.Emails;

namespace ShopTARge22.Controllers
{
    public class EmailsController : Controller
    {
        private readonly IEmailServices _emailServices;
        public EmailsController(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(EmailIndexViewModel vm)
        {
 
            EmailDtos newreq = new();
            newreq.To = vm.To;
            newreq.Subject = vm.Subject;
            newreq.Body = vm.Body;
            _emailServices.SendEmail(newreq);
            return Ok();
        }

    }
}
