using PagarMe;

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
    }
}
