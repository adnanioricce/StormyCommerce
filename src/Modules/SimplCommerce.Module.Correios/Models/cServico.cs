using System;
using System.Collections.Generic;
using System.Text;

namespace SimplCommerce.Module.Correios.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public class cServico
    {

        private int codigoField;

        private string valorField;

        private string prazoEntregaField;

        private string valorMaoPropriaField;

        private string valorAvisoRecebimentoField;

        private string valorValorDeclaradoField;

        private string entregaDomiciliarField;

        private string entregaSabadoField;

        private string erroField;

        private string msgErroField;

        private string valorSemAdicionaisField;

        private string obsFimField;

        private string dataMaxEntregaField;

        private string horaMaxEntregaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int Codigo
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
        public string Valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PrazoEntrega
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ValorMaoPropria
        {
            get
            {
                return this.valorMaoPropriaField;
            }
            set
            {
                this.valorMaoPropriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ValorAvisoRecebimento
        {
            get
            {
                return this.valorAvisoRecebimentoField;
            }
            set
            {
                this.valorAvisoRecebimentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string ValorValorDeclarado
        {
            get
            {
                return this.valorValorDeclaradoField;
            }
            set
            {
                this.valorValorDeclaradoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string EntregaDomiciliar
        {
            get
            {
                return this.entregaDomiciliarField;
            }
            set
            {
                this.entregaDomiciliarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string EntregaSabado
        {
            get
            {
                return this.entregaSabadoField;
            }
            set
            {
                this.entregaSabadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Erro
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string MsgErro
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string ValorSemAdicionais
        {
            get
            {
                return this.valorSemAdicionaisField;
            }
            set
            {
                this.valorSemAdicionaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string obsFim
        {
            get
            {
                return this.obsFimField;
            }
            set
            {
                this.obsFimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string DataMaxEntrega
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string HoraMaxEntrega
        {
            get
            {
                return this.horaMaxEntregaField;
            }
            set
            {
                this.horaMaxEntregaField = value;
            }
        }
    }
}
