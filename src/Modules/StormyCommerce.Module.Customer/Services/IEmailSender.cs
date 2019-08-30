using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message, bool isHtml = false);
    }
}
