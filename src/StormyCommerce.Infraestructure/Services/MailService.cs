using System.Threading.Tasks;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Infraestructure.Services
{
	//TODO: Implement: 
	//TODO:1-Contact Email 
	//TODO:2-Order Email 
	//TODO:3-Confirmation Account Email 
	//TODO:4-Shipped Email 
	//TODO:5-Cancelling order Email 
	
	public class MailService : IEmailService
	{        
		private readonly IEmailSender emailSender; 		
		public MailService(IEmailSender _emailSender)
		{
			emailSender = _emailSender; 
		}
        //TODO: Make a better message Model, the actual is not really useful
        public async Task SendEmailAsync(string to,string subject,string message)
        {            
            await emailSender.SendEmailAsync(to,subject, message);
        }       
    }
}
