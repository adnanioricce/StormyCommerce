using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Models;

namespace StormyCommerce.Infraestructure.Services
{
	public class EmailSender : IEmailSender 
	{
		public AuthMessageSenderOptions Options {get;}
		public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
		{
			Options = optionsAccessor.Value;
		}
		public async Task SendEmailAsync(string email,string subject,string message)
		{
			await ExecuteAsync(Options.SendGridKey,email,subject,message);
		}
		private async Task<Response> ExecuteAsync(string apiKey,string to,string subject,string message)
		{
			var client = new SendGridClient(apiKey);
			var msg = new SendGridMessage()
			{
				From = new EmailAddress("dnangonzaga@hotmail.com","change This later"),
				Subject = subject,				
				HtmlContent = message
			};
			msg.AddTo(new EmailAddress(to));
			msg.SetClickTracking(false,false); 
			return await client.SendEmailAsync(msg);
		}
	}
}
