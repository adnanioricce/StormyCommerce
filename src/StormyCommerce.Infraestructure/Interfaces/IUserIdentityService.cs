using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;
namespace StormyCommerce.Infraestructure.Interfaces
{
    public interface IUserIdentityService
    {
        Task<IdentityResult> ConfirmEmailAsync(User user,string code);
        Task<IdentityResult> CreateUserAsync(User user, string password);
        Task<IdentityResult> ResetPasswordAsync(User user,string token,string newPassword);
        Task<Result> AssignUserToRole(User user,string roleName);
        Task<string> GeneratePasswordResetTokenAsync(User user);
        Task<bool> IsEmailConfirmedAsync(User user);
        User GetUserByEmail(string email);
        Task<User> GetUserByEmailAsync(string email);
        User GetUserByUsername(string username);
        User GetUserById(long userId);
        PasswordVerificationResult VerifyHashPassword(User user,string hashedPassword,string providedPassword);
        Task<User> GetUserByClaimPrincipal(ClaimsPrincipal principal);
        Task<SignInResult> PasswordSignInAsync(User user, string password, bool isPersistent = true, bool lockoutInFailure = false);
        UserManager<User> GetUserManager();
        //Actually, you will not signout, it's a JWT based authentication
        Task SignOutAsync();
        IEnumerable<Claim> BuildClaims(User user);
        Task<string> CreateEmailConfirmationCode(User user);
        Task<Result> EditUserAsync(User customer);
        Task<Result> DeleteUserAsync(User user, string password);
    }
}
