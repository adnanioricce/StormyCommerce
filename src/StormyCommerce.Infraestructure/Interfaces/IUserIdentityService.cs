using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Interfaces
{
    public interface IUserIdentityService
    {
        Task<IdentityResult> ConfirmEmailAsync(StormyUser user,string code);
        Task<IdentityResult> CreateUserAsync(StormyUser user, string password);
        Task<IdentityResult> ResetPasswordAsync(StormyUser user,string token,string newPassword);
        Task<Result> AssignUserToRole(StormyUser user,string roleName);
        Task<string> GeneratePasswordResetTokenAsync(StormyUser user);
        Task<bool> IsEmailConfirmedAsync(StormyUser user);
        StormyUser GetUserByEmail(string email);
        Task<StormyUser> GetUserByEmailAsync(string email);
        StormyUser GetUserByUsername(string username);
        StormyUser GetUserById(long userId);
        PasswordVerificationResult VerifyHashPassword(StormyUser user,string hashedPassword,string providedPassword);
        Task<StormyUser> GetUserByClaimPrincipal(ClaimsPrincipal principal);
        Task<SignInResult> PasswordSignInAsync(StormyUser user, string password, bool isPersistent = true, bool lockoutInFailure = false);
        UserManager<StormyUser> GetUserManager();
        //Actually, you will not signout, it's a JWT based authentication
        Task SignOutAsync();
        IEnumerable<Claim> BuildClaims(StormyUser user);
        Task<string> CreateEmailConfirmationCode(StormyUser user);
        Task<Result> EditUserAsync(StormyUser customer);
        Task<Result> DeleteUserAsync(StormyUser user, string password);
    }
}
