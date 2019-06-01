using System.Threading.Tasks;
namespace StormyCommerce.Core.Interfaces
{
	public interface IEmailSender 
	{
		Task SendEmailAsync(string email,string subject,string message);
	}
}
