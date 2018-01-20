using Xamarin.Forms;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using B4.EE.DellobelI.Domain.Services.Abstract;

[assembly: Dependency(typeof(B4.EE.DellobelI.iOS.Services.EmailServiceIos))]

namespace B4.EE.DellobelI.iOS.Services
{
    public class EmailServiceIos : IEmailService

    {
        public  Task SendMailAsync(string subject, string body, string mailTo, string naamTo, string mailFrom, string naamFrom)

        {


            var apiKey = new ApiKey.ApiKey();
            var client = new SendGridClient(apiKey.Key);
            var msg = new SendGridMessage();
            var From = new SendGrid.Helpers.Mail.EmailAddress(mailFrom, naamFrom);
            var To = new SendGrid.Helpers.Mail.EmailAddress(mailTo, naamTo);
            var plainTextContent = body;
            var htmlContent = body;
            msg = MailHelper.CreateSingleEmail(From, To, subject, plainTextContent, htmlContent);

            return client.SendEmailAsync(msg);

        }

    }
}