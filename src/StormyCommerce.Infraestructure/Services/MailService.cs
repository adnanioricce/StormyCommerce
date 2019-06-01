﻿using System.Threading.Tasks;
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
        public async Task SendConfirmationEmailAsync(BaseMailMessage message, string username, string link)
        {
            //message.Message = TemplateGenerator.CreateConfirmationEmail(username, link);
            await emailSender.SendEmailAsync(message.To, message.Subject, message.Message);
        }
        public Task SendContactEmailAsync(BaseMailMessage messageModel,string username,string code)
        {
            throw new System.NotImplementedException();
        }
    }
}