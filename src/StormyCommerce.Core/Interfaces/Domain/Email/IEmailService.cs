using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string message);
    }
}
