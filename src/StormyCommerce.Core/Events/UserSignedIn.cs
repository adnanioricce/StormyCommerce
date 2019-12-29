using MediatR;

namespace StormyCommerce.Core.Events
{
    public class UserSignedIn : INotification
    {
        public long UserId { get; set; }
    }
}
