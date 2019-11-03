using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models.Correios
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public class cResultado
    {

        private cServico[] servicosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public cServico[] Servicos
        {
            get
            {
                return this.servicosField;
            }
            set
            {
                this.servicosField = value;
            }
        }
    }

    
}
