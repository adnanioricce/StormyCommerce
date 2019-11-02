using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Infraestructure.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole(){}
        public ApplicationRole(string role)
        {            
            this.Name = role;            
        }
    }
}