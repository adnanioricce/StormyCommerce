﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Orders.Services
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://resource.webservice.correios.com.br/", ConfigurationName = "Service")]
    public interface Service
    {

        [System.ServiceModel.OperationContractAttribute(Action = "buscaEventos", ReplyAction = "http://resource.webservice.correios.com.br/Service/buscaEventosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        Task<buscaEventosResponse> buscaEventosAsync(buscaEventosRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "buscaEventosLista", ReplyAction = "http://resource.webservice.correios.com.br/Service/buscaEventosListaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        Task<buscaEventosListaResponse> buscaEventosListaAsync(buscaEventosListaRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://resource.webservice.correios.com.br/")]
    public partial class sroxml
    {

        private string versaoField;

        private string qtdField;

        private string tipoPesquisaField;

        private string tipoResultadoField;

        private objeto[] objetoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string qtd
        {
            get
            {
                return this.qtdField;
            }
            set
            {
                this.qtdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string TipoPesquisa
        {
            get
            {
                return this.tipoPesquisaField;
            }
            set
            {
                this.tipoPesquisaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string TipoResultado
        {
            get
            {
                return this.tipoResultadoField;
            }
            set
            {
                this.tipoResultadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("objeto", Order = 4)]
        public objeto[] objeto
        {
            get
            {
                return this.objetoField;
            }
            set
            {
                this.objetoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://resource.webservice.correios.com.br/")]
    public partial class objeto
    {

        private string numeroField;

        private string siglaField;

        private string nomeField;

        private string categoriaField;

        private string erroField;

        private eventos[] eventoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string sigla
        {
            get
            {
                return this.siglaField;
            }
            set
            {
                this.siglaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string categoria
        {
            get
            {
                return this.categoriaField;
            }
            set
            {
                this.categoriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string erro
        {
            get
            {
                return this.erroField;
            }
            set
            {
                this.erroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("evento", Order = 5)]
        public eventos[] evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://resource.webservice.correios.com.br/")]
    public partial class eventos
    {

        private string tipoField;

        private string statusField;

        private string dataField;

        private string horaField;

        private string descricaoField;

        private string detalheField;

        private string recebedorField;

        private string documentoField;

        private string comentarioField;

        private string localField;

        private string codigoField;

        private string cidadeField;

        private string ufField;

        private string stoField;

        private string amazoncodeField;

        private string amazontimezoneField;

        private destinos[] destinoField;

        private enderecoMobile enderecoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string hora
        {
            get
            {
                return this.horaField;
            }
            set
            {
                this.horaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string detalhe
        {
            get
            {
                return this.detalheField;
            }
            set
            {
                this.detalheField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string recebedor
        {
            get
            {
                return this.recebedorField;
            }
            set
            {
                this.recebedorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string comentario
        {
            get
            {
                return this.comentarioField;
            }
            set
            {
                this.comentarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string local
        {
            get
            {
                return this.localField;
            }
            set
            {
                this.localField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string sto
        {
            get
            {
                return this.stoField;
            }
            set
            {
                this.stoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string amazoncode
        {
            get
            {
                return this.amazoncodeField;
            }
            set
            {
                this.amazoncodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string amazontimezone
        {
            get
            {
                return this.amazontimezoneField;
            }
            set
            {
                this.amazontimezoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("destino", Order = 16)]
        public destinos[] destino
        {
            get
            {
                return this.destinoField;
            }
            set
            {
                this.destinoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public enderecoMobile endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://resource.webservice.correios.com.br/")]
    public partial class destinos
    {

        private string localField;

        private string codigoField;

        private string cidadeField;

        private string bairroField;

        private string ufField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string local
        {
            get
            {
                return this.localField;
            }
            set
            {
                this.localField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://resource.webservice.correios.com.br/")]
    public partial class enderecoMobile
    {

        private string codigoField;

        private string cepField;

        private string logradouroField;

        private string complementoField;

        private string numeroField;

        private string localidadeField;

        private string ufField;

        private string bairroField;

        private string latitudeField;

        private string longitudeField;

        private string celularField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string cep
        {
            get
            {
                return this.cepField;
            }
            set
            {
                this.cepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string logradouro
        {
            get
            {
                return this.logradouroField;
            }
            set
            {
                this.logradouroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string localidade
        {
            get
            {
                return this.localidadeField;
            }
            set
            {
                this.localidadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string celular
        {
            get
            {
                return this.celularField;
            }
            set
            {
                this.celularField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "buscaEventos", WrapperNamespace = "http://resource.webservice.correios.com.br/", IsWrapped = true)]
    public partial class buscaEventosRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string resultado;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lingua;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string objetos;

        public buscaEventosRequest()
        {
        }

        public buscaEventosRequest(string usuario, string senha, string tipo, string resultado, string lingua, string objetos)
        {
            this.usuario = usuario;
            this.senha = senha;
            this.tipo = tipo;
            this.resultado = resultado;
            this.lingua = lingua;
            this.objetos = objetos;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "buscaEventosResponse", WrapperNamespace = "http://resource.webservice.correios.com.br/", IsWrapped = true)]
    public partial class buscaEventosResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public sroxml @return;

        public buscaEventosResponse()
        {
        }

        public buscaEventosResponse(sroxml @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "buscaEventosLista", WrapperNamespace = "http://resource.webservice.correios.com.br/", IsWrapped = true)]
    public partial class buscaEventosListaRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string resultado;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lingua;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("objetos", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] objetos;

        public buscaEventosListaRequest()
        {
        }

        public buscaEventosListaRequest(string usuario, string senha, string tipo, string resultado, string lingua, string[] objetos)
        {
            this.usuario = usuario;
            this.senha = senha;
            this.tipo = tipo;
            this.resultado = resultado;
            this.lingua = lingua;
            this.objetos = objetos;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "buscaEventosListaResponse", WrapperNamespace = "http://resource.webservice.correios.com.br/", IsWrapped = true)]
    public partial class buscaEventosListaResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://resource.webservice.correios.com.br/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public sroxml @return;

        public buscaEventosListaResponse()
        {
        }

        public buscaEventosListaResponse(sroxml @return)
        {
            this.@return = @return;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public interface ServiceChannel : Service, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public class ServiceClient : System.ServiceModel.ClientBase<Service>, Service
    {

        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        //static void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public ServiceClient() :
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ServicePort.ToString();            
        }

        public ServiceClient(EndpointConfiguration endpointConfiguration) :
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();           
        }

        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();            
        }

        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();            
        }

        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Task<buscaEventosResponse> Service.buscaEventosAsync(buscaEventosRequest request)
        {
            return base.Channel.buscaEventosAsync(request);
        }

        public Task<buscaEventosResponse> buscaEventosAsync(string usuario, string senha, string tipo, string resultado, string lingua, string objetos)
        {
            buscaEventosRequest inValue = new buscaEventosRequest();
            inValue.usuario = usuario;
            inValue.senha = senha;
            inValue.tipo = tipo;
            inValue.resultado = resultado;
            inValue.lingua = lingua;
            inValue.objetos = objetos;
            return ((Service)(this)).buscaEventosAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Task<buscaEventosListaResponse> Service.buscaEventosListaAsync(buscaEventosListaRequest request)
        {
            return base.Channel.buscaEventosListaAsync(request);
        }

        public Task<buscaEventosListaResponse> buscaEventosListaAsync(string usuario, string senha, string tipo, string resultado, string lingua, string[] objetos)
        {
            buscaEventosListaRequest inValue = new buscaEventosListaRequest();
            inValue.usuario = usuario;
            inValue.senha = senha;
            inValue.tipo = tipo;
            inValue.resultado = resultado;
            inValue.lingua = lingua;
            inValue.objetos = objetos;
            return ((Service)(this)).buscaEventosListaAsync(inValue);
        }

        public virtual Task OpenAsync()
        {
            return Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual Task CloseAsync()
        {
            return Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://webservice.correios.com.br/service/rastro");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.ServicePort);
        }

        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.ServicePort);
        }

        public enum EndpointConfiguration
        {

            ServicePort,
        }
    }
}
