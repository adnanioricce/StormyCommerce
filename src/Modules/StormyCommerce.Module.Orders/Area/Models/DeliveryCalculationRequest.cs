using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Orders.Area.Models
{
    public class DeliveryCalculationRequest
    {
        ///<summary>
        /// The shipping service/method to be used
        /// Options:
        /// -Pac(41106)
        /// -Sedex(40010)
        /// -SedexACobrar(40045)
        /// -Sedex12(40169)
        /// -Sedex10(40215)
        /// -SedexHoje(40290)
        ///</summary>
        [Required]
        [StringLength(5)]        
        public string ServiceCode { get; set; }
        ///<summary>
        /// The format of the shipping box 
        /// Options:
        /// 1 - Box or package
        /// 2 - Cylinder or prism
        /// 3 - Envelope
        ///</summary>
        public string FormatCode { get; set; }
        
    }
}