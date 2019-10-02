using System;

namespace StormyCommerce.Module.Orders.Area.Models
{
    public class CalculateShippingResponseModel
    {
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string PrazoEntrega { get; set; }
        public string ValorMaoPropria { get; set; }
        public string ValorAvisoRecebiment { get; set; }
        public string EntregaDomiciliar { get; set; }
        public string EntregaSabado { get; set; }
        public string Erro { get; set; }
        public string MensagemErro { get; set; }        
    }
}
