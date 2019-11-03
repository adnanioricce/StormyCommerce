using StormyCommerce.Module.Orders.Interfaces;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using StormyCommerce.Module.Orders.Area.Models.Correios;

namespace StormyCommerce.Module.Orders.Services
{
    public class CalcPrecoPrazoWSSoapClient : ClientBase<ICalcPrecoPrazoWSSoap>, ICalcPrecoPrazoWSSoap
    {

        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        // static partial void ConfigureEndpoint(ServiceEndpoint serviceEndpoint, ClientCredentials clientCredentials);

        public CalcPrecoPrazoWSSoapClient(EndpointConfiguration endpointConfiguration = EndpointConfiguration.CalcPrecoPrazoWSSoap) :
                base(CalcPrecoPrazoWSSoapClient.GetBindingForEndpoint(endpointConfiguration), CalcPrecoPrazoWSSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            // ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public CalcPrecoPrazoWSSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(CalcPrecoPrazoWSSoapClient.GetBindingForEndpoint(endpointConfiguration), new EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            // ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public CalcPrecoPrazoWSSoapClient(EndpointConfiguration endpointConfiguration, EndpointAddress remoteAddress) :
                base(CalcPrecoPrazoWSSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            // ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public CalcPrecoPrazoWSSoapClient(Binding binding, EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }        

        public Task<cResultado> CalcPrecoPrazoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento)
        {
            return base.Channel.CalcPrecoPrazoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
        }

        public Task<cResultado> CalcPrecoPrazoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            return base.Channel.CalcPrecoPrazoDataAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }

        public Task<cResultado> CalcPrecoPrazoRestricaoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            return base.Channel.CalcPrecoPrazoRestricaoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }

        public Task<cResultado> CalcPrecoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento)
        {
            return base.Channel.CalcPrecoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
        }

        public Task<cResultado> CalcPrecoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            return base.Channel.CalcPrecoDataAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }

        public Task<cResultado> CalcPrazoAsync(string nCdServico, string sCepOrigem, string sCepDestino)
        {
            return base.Channel.CalcPrazoAsync(nCdServico, sCepOrigem, sCepDestino);
        }

        public Task<cResultado> CalcPrazoDataAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo)
        {
            return base.Channel.CalcPrazoDataAsync(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
        }

        public Task<cResultado> CalcPrazoRestricaoAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo)
        {
            return base.Channel.CalcPrazoRestricaoAsync(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
        }

        public Task<cResultado> CalcPrecoFACAsync(string nCdServico, string nVlPeso, string strDataCalculo)
        {
            return base.Channel.CalcPrecoFACAsync(nCdServico, nVlPeso, strDataCalculo);
        }

        public Task<cResultadoObjeto> CalcDataMaximaAsync(string codigoObjeto)
        {
            return base.Channel.CalcDataMaximaAsync(codigoObjeto);
        }

        public Task<cResultadoServicos> ListaServicosAsync()
        {
            return base.Channel.ListaServicosAsync();
        }

        public Task<cResultadoServicos> ListaServicosSTARAsync()
        {
            return base.Channel.ListaServicosSTARAsync();
        }

        public Task<cResultadoModal> VerificaModalAsync(string nCdServico, string sCepOrigem, string sCepDestino)
        {
            return base.Channel.VerificaModalAsync(nCdServico, sCepOrigem, sCepDestino);
        }

        public Task<versao> getVersaoAsync()
        {
            return base.Channel.getVersaoAsync();
        }

        public virtual Task OpenAsync()
        {
            return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((ICommunicationObject)(this)).EndOpen));
        }

        public virtual Task CloseAsync()
        {
            return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((ICommunicationObject)(this)).EndClose));
        }

        private static Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CalcPrecoPrazoWSSoap))
            {
                var result = new BasicHttpBinding
                {
                    MaxBufferSize = int.MaxValue,
                    ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max,
                    MaxReceivedMessageSize = int.MaxValue,
                    AllowCookies = true
                };
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CalcPrecoPrazoWSSoap12))
            {
                var result = new CustomBinding();
                var textBindingElement = new TextMessageEncodingBindingElement
                {
                    MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None)
                };
                result.Elements.Add(textBindingElement);
                var httpBindingElement = new HttpTransportBindingElement
                {
                    AllowCookies = true,
                    MaxBufferSize = int.MaxValue,
                    MaxReceivedMessageSize = int.MaxValue
                };
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }

        private static EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CalcPrecoPrazoWSSoap))
            {
                return new EndpointAddress("http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.CalcPrecoPrazoWSSoap12))
            {
                return new EndpointAddress("http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }

        public enum EndpointConfiguration
        {

            CalcPrecoPrazoWSSoap,

            CalcPrecoPrazoWSSoap12,
        }
    }
}
