using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Interfaces
{
    public interface IUserIdentityService
    {
        Task<IdentityResult> ConfirmEmailAsync(StormyCustomer user,string code);
        Task<IdentityResult> CreateUserAsync(StormyCustomer user, string password);
        Task<IdentityResult> ResetPasswordAsync(StormyCustomer user,string token,string newPassword);
        Task<IdentityResult> AssignUserToRole(StormyCustomer user,string roleName);
        Task<string> GeneratePasswordResetTokenAsync(StormyCustomer user);
        Task<bool> IsEmailConfirmedAsync(StormyCustomer user);
        StormyCustomer GetUserByEmail(string email);
        StormyCustomer GetUserByUsername(string username);
        StormyCustomer GetUserById(string userId);
        PasswordVerificationResult VerifyHashPassword(StormyCustomer user,string hashedPassword,string providedPassword);
        Task<StormyCustomer> GetUserByClaimPrincipal(ClaimsPrincipal principal);
        Task<SignInResult> PasswordSignInAsync(StormyCustomer user, string password, bool isPersistent = true, bool lockoutInFailure = false);
        UserManager<StormyCustomer> GetUserManager();

        //Actually, you will not signout, it's a JWT based authentication
        Task SignOutAsync();

        Task<IEnumerable<Claim>> BuildClaims(StormyCustomer user);

        Task<string> CreateEmailConfirmationCode(StormyCustomer user);
        Task EditUserAsync(StormyCustomer customer);
    }
}
