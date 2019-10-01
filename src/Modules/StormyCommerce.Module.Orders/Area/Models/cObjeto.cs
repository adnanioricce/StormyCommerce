using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public partial class cObjeto
    {

        private string codigoField;

        private string servicoField;

        private string cepOrigemField;

        private string cepDestinoField;

        private int prazoEntregaField;

        private string dataPostagemField;

        private string dataPostagemCalculoField;

        private string dataMaxEntregaField;

        private string postagemDHField;

        private string dataUltimoEventoField;

        private string codigoUltimoEventoField;

        private string tipoUltimoEventoField;

        private string descricaoUltimoEventoField;

        private string erroField;

        private string msgErroField;

        private string nuTicketField;

        private string formaPagamentoField;

        private string valorPagamentoField;

        private string nuContratoField;

        private string nuCartaoPostagemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string servico
        {
            get
            {
                return this.servicoField;
            }
            set
            {
                this.servicoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string cepOrigem
        {
            get
            {
                return this.cepOrigemField;
            }
            set
            {
                this.cepOrigemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string cepDestino
        {
            get
            {
                return this.cepDestinoField;
            }
            set
            {
                this.cepDestinoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int prazoEntrega
        {
            get
            {
                return this.prazoEntregaField;
            }
            set
            {
                this.prazoEntregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string dataPostagem
        {
            get
            {
                return this.dataPostagemField;
            }
            set
            {
                this.dataPostagemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string dataPostagemCalculo
        {
            get
            {
                return this.dataPostagemCalculoField;
            }
            set
            {
                this.dataPostagemCalculoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string dataMaxEntrega
        {
            get
            {
                return this.dataMaxEntregaField;
            }
            set
            {
                this.dataMaxEntregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string postagemDH
        {
            get
            {
                return this.postagemDHField;
            }
            set
            {
                this.postagemDHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string dataUltimoEvento
        {
            get
            {
                return this.dataUltimoEventoField;
            }
            set
            {
                this.dataUltimoEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string codigoUltimoEvento
        {
            get
            {
                return this.codigoUltimoEventoField;
            }
            set
            {
                this.codigoUltimoEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string tipoUltimoEvento
        {
            get
            {
                return this.tipoUltimoEventoField;
            }
            set
            {
                this.tipoUltimoEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string descricaoUltimoEvento
        {
            get
            {
                return this.descricaoUltimoEventoField;
            }
            set
            {
                this.descricaoUltimoEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string msgErro
        {
            get
            {
                return this.msgErroField;
            }
            set
            {
                this.msgErroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string nuTicket
        {
            get
            {
                return this.nuTicketField;
            }
            set
            {
                this.nuTicketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string formaPagamento
        {
            get
            {
                return this.formaPagamentoField;
            }
            set
            {
                this.formaPagamentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string valorPagamento
        {
            get
            {
                return this.valorPagamentoField;
            }
            set
            {
                this.valorPagamentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string nuContrato
        {
            get
            {
                return this.nuContratoField;
            }
            set
            {
                this.nuContratoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string nuCartaoPostagem
        {
            get
            {
                return this.nuCartaoPostagemField;
            }
            set
            {
                this.nuCartaoPostagemField = value;
            }
        }
    }
}
