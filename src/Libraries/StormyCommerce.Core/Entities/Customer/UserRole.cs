using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.Customer
{
    public class UserRole : IdentityUserRole<long>
    {
        public override long UserId { get; set; }

        public virtual StormyCustomer User { get; set; }

        public override long RoleId { get; set; }

        public virtual ApplicationRole Role { get; set; }
    }
}
