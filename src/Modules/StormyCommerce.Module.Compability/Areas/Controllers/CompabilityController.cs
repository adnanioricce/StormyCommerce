using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using StormyCommerce.Module.Compability.Areas.ViewModels;
using SimplCommerce.Module.Core.Areas.Core.ViewModels;
namespace StormyCommerce.Module.Compability.Areas.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CompabilityController : Controller
    {
        [HttpPost("/api/Authentication/login")]
        public IActionResult OldAuth(SignInVm request)
        {
            //TODO: redirect to /Account/Login
            return new RedirectResult("/Account/Login",true);
            // return new RedirectResult("/Account/Login",new {
            //     Email = request.Email,
            //     Password = request.Password
            // });
            
        }
        [HttpPost("/api/Authentication/register")]
        public IActionResult oldSignUp(SignUpVm request)
        {
            //TODO: redirect to /Account/register
            return new RedirectResult("/Account/Register");
            // return new RedirectResult("/Account/Register",new {
            //     Email = request.Email,
            //     Password = request.Password,
            //     ConfirmPassword = request.ConfirmPassword,
            //     FullName = string.IsNullOrEmpty(request.UserName) ? $"fullnameuser-{Guid.NewGuid().ToString()}" : request.UserName
            // });
        }                
        [HttpPost("api/Account/get_current_user")]
        public async Task<object> GetCurrentUser()
        {
            return NoContent();
        }
        [HttpPost("api/Account/add_shipping_address")]
        public IActionResult AddDefaultShippingAddress(CreateShippingAddressRequest model)
        {
            var formModel = new UserAddressFormViewModel{
                ContactName = "a name",
                Phone = "11111111111",
                AddressLine1 = model.Address.FirstAddress,
                AddressLine2 = model.Address.SecondAddress,
                ZipCode = model.Address.PostalCode,
                City = model.Address.City,
                
            };
            return new RedirectResult("user/address/create",true);
        }
        [HttpPost("api/WishList/get")]
        public async Task<object> GetWishList()
        {
            return new {
                NoContent = "this feature is under maintenance"
            };
        }
        [HttpPost("api/Checkout/credit_card")]
        public async Task<CheckoutResponse> Checkout(CheckoutBoletoRequest request)
        {
            return new CheckoutResponse{
                Order = {

                }
            };
        }
    }
}