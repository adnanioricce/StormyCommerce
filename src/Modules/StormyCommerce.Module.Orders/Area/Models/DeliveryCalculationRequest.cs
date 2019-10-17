using System.ComponentModel.DataAnnotations;
using StormyCommerce.Module.Orders.Area.Models.Correios;
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
        [Required]
        public FormatCode FormatCode { get; set; }
        ///<summary>
        /// Height of the object in centimeters        
        ///</summary>
        [Required]
        public decimal Height { get; set; }
        ///<summary>
        /// Width of the object in centimeters        
        ///</summary>
        [Required]
        public decimal Width { get; set; }
        ///<summary>
        /// Length of the object in centimeters        
        ///</summary>
        [Required]
        public decimal Length { get; set; }
        ///<summary>
        /// Diameter of the object in centimeters        
        ///</summary>
        [Required]
        public decimal Diameter { get; set; }
        ///<summary>
        /// The destination postal code for the shipping        
        ///</summary>
        // public string OriginPostalCode { get; set; }
        [Required]
        public string DestinationPostalCode { get; set; }
        ///<summary>
        /// A secure tax in case of problems on shipping        
        ///</summary>
        public decimal ValorDeclarado { get; set; } = 0.0m;
        //TODO:is the name right?
        ///<summary>
        /// Notification service of Correios when object is shipped         
        ///</summary>
        public string WarningOfReceiving { get; set; } = "N";
        ///<summary>
        /// TODO:         
        ///</summary>
        public string MaoPropria { get; set; } = "N";        
        
    }
}