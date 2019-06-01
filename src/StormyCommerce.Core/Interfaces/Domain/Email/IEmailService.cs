using System.Threading.Tasks;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Core.Interfaces
{
	public interface IEmailService
	{
		Task SendConfirmationEmailAsync(BaseMailMessage message,string username,string link); 
		Task SendContactEmailAsync(BaseMailMessage message,string username,string code); 
	}
}
