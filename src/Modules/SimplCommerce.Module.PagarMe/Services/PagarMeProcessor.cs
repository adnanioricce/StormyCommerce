using SimplCommerce.Module.Payments.Interfaces;
namespace SimplCommerce.Module.PagarMe.Services
{
    public class PagarMeProcessor : IPaymentProvider
    {        
        private readonly IRepository<Cart> _cartRepository;
        private readonly IRepository<Address> _addressRepository;
        // private readonly IRepository<>
        public PagarMeProcessor()
        {
            
        }
        public ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
        {
            var cart = await _cartRepository.GetByIdAsync(request.CartId);
            var amount = cart.Items.Sum(c => c.Quantity * c.Product.Price);
            
        }
    }
}