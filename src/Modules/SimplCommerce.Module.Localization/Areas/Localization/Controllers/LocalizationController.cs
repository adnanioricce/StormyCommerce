using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Extensions;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Entities;
namespace SimplCommerce.Module.Localization.Areas.Localization.Controllers
{
    [Area("Localization")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class LocalizationController : Controller
    {
        private readonly IStormyRepository<User> _userRepository;
        private readonly IWorkContext _workContext;

        public LocalizationController(IStormyRepository<User> userRepository, IWorkContext workContext)
        {
            _userRepository = userRepository;
            _workContext = workContext;
        }

        [HttpPost]
        public async Task<IActionResult> SetLanguage(string culture, string returnUrl)
        {
            var currentUser = await _workContext.GetCurrentUser();

            currentUser.Culture = culture;
            _userRepository.SaveChanges();

            return LocalRedirect(returnUrl);
        }
    }
}
