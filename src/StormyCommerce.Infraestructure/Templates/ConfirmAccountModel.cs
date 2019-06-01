using System;
namespace StormyCommerce.Infraestructure.Templates
{
    public class ConfirmAccountModel
    {
        public string Username { get; set; }
        public string ConfirmationCode { get; set; } = Guid.NewGuid().ToString("N");
        public string LinkToCheckPage {get;set;} 
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        
    }
}