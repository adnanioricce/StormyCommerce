using System.Threading.Tasks;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Core.Interfaces
{
	public interface IEmailService
	{
		Task SendEmailAsync(string to,string subject,string message); 		
	}
}
