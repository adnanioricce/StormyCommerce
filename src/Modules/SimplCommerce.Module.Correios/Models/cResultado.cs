using System;
using System.Collections.Generic;
using System.Text;

namespace SimplCommerce.Module.Correios.Models
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
