using System.Threading.Tasks;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.Core.Extensions
{
    public interface IWorkContext
    {
        Task<User> GetCurrentUser();
    }
}
