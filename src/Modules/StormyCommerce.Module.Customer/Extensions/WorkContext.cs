using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Entities;
using System;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Extensions
{
    //"Ported" from the original project
    public class WorkContext : IWorkContext
    {
        //TODO:Modify to return a StormyCustomer or ApplicationUser
        private const string UserGuidCookiesName = "SimplUserGuid";
        private const long GuestRoleId = 3;

        private ApplicationUser _currentUser;
        private UserManager<ApplicationUser> _userManager;
        private HttpContext _httpContext;
        private IStormyRepository<StormyCustomer> _userRepository;

        public WorkContext(UserManager<ApplicationUser> userManager, IHttpContextAccessor contextAccessor, IStormyRepository<StormyCustomer> userRepository)
        {
            _userManager = userManager;
            _httpContext = contextAccessor.HttpContext;
            _userRepository = userRepository;
        }

        public async Task<ApplicationUser> GetCurrentApplicationUser()
        {
            if (_currentUser != null)
            {
                return _currentUser;
            }

            var contextUser = _httpContext.User;
            _currentUser = await _userManager.GetUserAsync(contextUser);

            if (_currentUser != null)
            {
                return _currentUser;
            }

            var userGuid = GetUserGuidFromCookies();
            //if (userGuid.HasValue)
            //{
            //    _currentUser = _userRepository.Table.Include(x => x.ro).FirstOrDefault(x => x.UserGuid == userGuid);
            //}

            //if (_currentUser != null && _currentUser.Roles.Count == 1 && _currentUser.Roles.First().RoleId == GuestRoleId)
            //{
            //    return _currentUser;
            //}

            userGuid = Guid.NewGuid();
            var dummyEmail = string.Format("{0}@guest.simplcommerce.com", userGuid);
            _currentUser = new ApplicationUser
            {
                //FullName = "Guest",
                // = userGuid.Value.ToString(),
                Email = dummyEmail,
                UserName = dummyEmail,
                //Culture = GlobalConfiguration.DefaultCulture
            };
            var abc = await _userManager.CreateAsync(_currentUser, "1qazZAQ!");
            await _userManager.AddToRoleAsync(_currentUser, "guest");
            SetUserGuidCookies(new Guid(_currentUser.Id));
            return _currentUser;
        }

        public async Task<StormyCustomer> GetCurrentCustomer()
        {
            var appUser = await GetCurrentApplicationUser();
            return await _userRepository.Table.FirstOrDefaultAsync(u => u.Email.Equals(appUser.Email));
        }

        private Guid? GetUserGuidFromCookies()
        {
            if (_httpContext.Request.Cookies.ContainsKey(UserGuidCookiesName))
            {
                return Guid.Parse(_httpContext.Request.Cookies[UserGuidCookiesName]);
            }

            return null;
        }

        private void SetUserGuidCookies(Guid userGuid)
        {
            _httpContext.Response.Cookies.Append(UserGuidCookiesName, _currentUser.Id, new CookieOptions
            {
                Expires = DateTime.UtcNow.AddYears(5),
                HttpOnly = true,
                IsEssential = true
            });
        }
    }
}
