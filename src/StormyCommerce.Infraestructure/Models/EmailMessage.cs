using StormyCommerce.Core.Models;

namespace StormyCommerce.Infraestructure.Models
{
    public class EmailMessage : BaseMailMessage
    {
        // public string ConfirmationEmailTemplate(ConfirmationEmailModel emailModel)
        // {

        // 	return 
        // }		
        public EmailMessage(string to, string subject, string message) : base(to, subject, message)
        {
        }
    }
}
