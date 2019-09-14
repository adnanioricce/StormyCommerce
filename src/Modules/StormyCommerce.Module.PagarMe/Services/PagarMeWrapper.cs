using PagarMe;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;

namespace StormyCommerce.Module.PagarMe.Services
{
    //TODO:
    public class PagarMeWrapper
    {
        private readonly PagarMeService _pagarMeService;

        public PagarMeWrapper(PagarMeService pagarMeService)
        {
            _pagarMeService = pagarMeService;
        }        
        public void SaveTransaction(Transaction transaction)
        {   
            transaction.Save();            
        }        
        
    }
}
