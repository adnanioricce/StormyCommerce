using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message, bool isHtml = false);
    }
}
