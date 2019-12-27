using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Infraestructure.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Extensions
{
    //"Ported" from the original project
    public class WorkContext : IWorkContext
    {
        //TODO:Modify to return a StormyCustomer or ApplicationUser
        private const string UserGuidCookiesName = "SimplUserGuid";
        private const long GuestRoleId = 3;

        private StormyUser _currentUser;
        private readonly IUserIdentityService _userIdentityService;
        private readonly UserManager<StormyUser> _userManager;
        private readonly HttpContext _httpContext;
        private readonly ICustomerService _customerService;

        public WorkContext(UserManager<StormyUser> userManager,
         IHttpContextAccessor contextAccessor, 
         ICustomerService customerService,
         IUserIdentityService userIdentityService)
        {
            _userManager = userManager;
            _httpContext = contextAccessor.HttpContext;
            _customerService = customerService;
            _userIdentityService = userIdentityService;
        }

        public async Task<StormyUser> GetCurrentApplicationUser()
        {
            if (_currentUser != null)
            {
                return _userIdentityService.GetUserById(_currentUser.Id);
            }
            var contextUser = _userIdentityService.GetUserByEmail(_httpContext.User.Claims.FirstOrDefault(c => c.Type.Contains("email")).Value);            

            if (contextUser != null && contextUser.Id == _currentUser.Id)
            {
                return contextUser;
            }                      
            return await CreateGuestUser();              
           
        }
        public async Task<StormyUser> CreateGuestUser()
        {
            var userGuid = Guid.NewGuid().ToString();
            var dummyEmail = string.Format("{0}@guest.simplcommerce.com", userGuid);
            var guestUser = new StormyUser
            {                 
                Id = 0,
                Email = dummyEmail,
                UserName = dummyEmail,                
            };            
            var createResult = await _userIdentityService.CreateUserAsync(guestUser,"1qazZAQ!");
            await _userIdentityService.AssignUserToRole(guestUser, "guest");
            SetUserGuidCookies(new Guid(userGuid));
            return guestUser;
        }
        public async Task<StormyUser> GetCurrentCustomer()
        {
            return await _userIdentityService.GetUserByClaimPrincipal(_httpContext.User);
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
            _httpContext.Response.Cookies.Append(UserGuidCookiesName, userGuid.ToString(), new CookieOptions
            {
                Expires = DateTime.UtcNow.AddYears(5),
                HttpOnly = true,
                IsEssential = true
            });
        }
    }
}
