using System;

namespace StormyCommerce.Core.Models 
{
	public class BaseMailMessage 
	{
		public string To { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public string MessageToEmailTemplate()
		{
			//TODO: Return the template here
			return String.Format($"Hello {To}, {Message}");
		}

	}
}
