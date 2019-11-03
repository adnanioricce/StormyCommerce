using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using StormyCommerce.Infraestructure.Interfaces;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimplCommerce.Module.EmailSenderSendgrid
{
    public class EmailSender : IEmailSender
    {
        private readonly string _apiKey;
        private readonly string _from;

        public EmailSender(IConfiguration configuration)
        {
            _apiKey = configuration.GetValue<string>("SendGrid:Email:ApiKey");
            _from = configuration.GetValue<string>("SendGrid:Email:From");

            Contract.Requires(string.IsNullOrWhiteSpace(_apiKey));
            Contract.Requires(string.IsNullOrWhiteSpace(_from));
        }

        public async Task SendEmailAsync(string email, string subject, string message, bool isHtml = false)
        {
            Contract.Requires(string.IsNullOrWhiteSpace(email));
            Contract.Requires(string.IsNullOrWhiteSpace(subject));
            Contract.Requires(string.IsNullOrWhiteSpace(message));

            var sendGridMessage = new SendGridMessage
            {
                From = new EmailAddress(_from),
                Subject = subject,
                HtmlContent = isHtml ? message : "",
                PlainTextContent = isHtml ? Regex.Replace(message,"<[^>]*>","") : message,                
            };
            sendGridMessage.AddTo(new EmailAddress(email));            
            var client = new SendGridClient(_apiKey);
            await client.SendEmailAsync(sendGridMessage);
        }
    }
}
