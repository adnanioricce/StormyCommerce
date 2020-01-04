using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Events;
using SimplCommerce.Module.Core.Extensions;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Entities;
namespace SimplCommerce.Module.Localization.Events
{
    public class UserSignedInHandler : INotificationHandler<UserSignedIn>
    {
        private readonly IWorkContext _workContext;
        private readonly IStormyRepository<User> _userRepository;

        public UserSignedInHandler(IWorkContext workContext, IStormyRepository<User> userRepository)
        {
            _workContext = workContext;
            _userRepository = userRepository;
        }

        public async Task Handle(UserSignedIn user, CancellationToken cancellationToken)
        {
            var guestUser = await _workContext.GetCurrentUser();
            var signedInUser = await _userRepository.Query().SingleAsync(u => u.Id == user.UserId);
            signedInUser.Culture = guestUser.Culture;
            await _userRepository.SaveChangesAsync();
        }
    }
}
