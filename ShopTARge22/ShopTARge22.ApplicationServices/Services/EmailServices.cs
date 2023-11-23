using MimeKit;
using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;

namespace ShopTARge22.ApplicationServices.Services
{
    public class EmailServices : IEmailServices
    {
        public void SendEmail(EmailDtos request)
        {
            /*var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("fromtest"));
            email.To.Add(MailboxAddress.Parse("totest"));
            email.Subject*/
        }
    }
}
