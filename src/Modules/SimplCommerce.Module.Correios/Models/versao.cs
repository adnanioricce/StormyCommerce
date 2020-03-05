using System;
using System.Collections.Generic;
using System.Text;

namespace SimplCommerce.Module.Correios.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public partial class versao
    {

        private string versaoAtualField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string versaoAtual
        {
            get
            {
                return this.versaoAtualField;
            }
            set
            {
                this.versaoAtualField = value;
            }
        }
    }
}
