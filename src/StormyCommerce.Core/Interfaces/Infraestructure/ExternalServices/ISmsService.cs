using System.Threading.Tasks;
namespace StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices
{
	public interface ISmsService 
	{
		Task SendSmsAsync(string number,string message);
	}
}
