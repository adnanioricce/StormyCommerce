using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class VendorDto
    {
        public VendorDto(){}
        public VendorDto(Vendor vendor)
        {
            CompanyName = vendor.CompanyName; 
            ContactTitle = vendor.ContactTitle; 
            Phone = vendor.Phone; 
            Email = vendor.Email;
            WebSite = vendor.WebSite;
            TypeGoods = vendor.TypeGoods; 
            SizeUrl = vendor.SizeUrl; 
            Logo = vendor.Logo;
            Note = vendor.Note;
        }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }  
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string TypeGoods { get; set; }
        public string SizeUrl { get; set; }
        public string Logo { get; set; }
        public string Note { get; set; }
    }
}
