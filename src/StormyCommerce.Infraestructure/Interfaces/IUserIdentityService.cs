using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Entities;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Interfaces
{
    public interface IUserIdentityService
    {
        Task<IdentityResult> ConfirmEmailAsync(ApplicationUser user,string code);
        Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password);
        Task<IdentityResult> ResetPasswordAsync(ApplicationUser user,string token,string newPassword);
        Task<IdentityResult> AssignUserToRole(ApplicationUser user,string roleName);
        Task<string> GeneratePasswordResetTokenAsync(ApplicationUser user);
        Task<bool> IsEmailConfirmedAsync(ApplicationUser user);
        ApplicationUser GetUserByEmail(string email);
        ApplicationUser GetUserByUsername(string username);
        ApplicationUser GetUserById(string userId);
        PasswordVerificationResult VerifyHashPassword(ApplicationUser user,string hashedPassword,string providedPassword);
        Task<ApplicationUser> GetUserByClaimPrincipal(ClaimsPrincipal principal);
        Task<SignInResult> PasswordSignInAsync(ApplicationUser user, string password, bool isPersistent = true, bool lockoutInFailure = false);
        UserManager<ApplicationUser> GetUserManager();

        //Actually, you will not signout, it's a JWT based authentication
        Task SignOutAsync();

        Task<IEnumerable<Claim>> BuildClaims(ApplicationUser user);

        Task<string> CreateEmailConfirmationCode(ApplicationUser user);
    }
}
