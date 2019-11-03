using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models.Correios
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
