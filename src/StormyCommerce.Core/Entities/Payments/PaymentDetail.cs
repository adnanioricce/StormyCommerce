using StormyCommerce.Core.Entities.Customer;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormyCommerce.Core.Entities.Payments
{
	public class PaymentDetail : BaseEntity
	{
        public int ConsumerId { get; set; }
        [NotMapped]
        public StormyConsumer UserDetails { get; set;}		
	}
}
