using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.Customer
{
    public class ApplicationUserRole : IdentityUserRole<string>,IEntityBaseWithTypedId<long>
    {
        public virtual StormyCustomer User { get; set; }
        public virtual ApplicationRole Role { get; set; }
        public long Id { get;set; }
    }
}