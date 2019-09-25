namespace StormyCommerce.Module.Shipping.Areas.Shipping.Models
{
    public class CalculateShippingModel
    {
        public string CodigoEmpresa { get; set; }
        public string sDsSenha { get; set; }
        public string CodigoServico { get; set; }
        public string CepOrigem  { get; set; }
        public string CepDestino  { get; set; }
        public string Peso  { get; set; }
        public int CodigoFormato  { get; set; }
        public decimal Comprimento { get; set; }
        public decimal Altura  { get; set; }
        public decimal Largura  { get; set; }
        public decimal Diametro  { get; set; }
        public string CodigoMaoPropria { get; set; }
        public decimal ValorDeclarado { get; set; }
        public string CodigoAvisoRecebimento { get; set; }
        // public string MyProperty { get; set; }
    }
}
