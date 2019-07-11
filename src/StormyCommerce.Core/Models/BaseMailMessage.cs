using System;

namespace StormyCommerce.Core.Models 
{
	public class BaseMailMessage 
	{
		public string To { get; private set; }
		public string Subject { get; private set; }
		public string Message { get; private set; }
        public BaseMailMessage(string to,string subject,string message)
        {
            To = to;
            Subject = subject;
            Message = message;
        }
		public static BaseMailMessage ToConfirmationEmail(string username, string link)
		{            
            return new BaseMailMessage(username, "Account Confirmation", String.Format($"click on the link to confirm your account:{link}"));
		}

	}
}
