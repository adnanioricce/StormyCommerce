using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public partial class cResultadoModal
    {

        private cModal[] servicosModalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public cModal[] ServicosModal
        {
            get
            {
                return this.servicosModalField;
            }
            set
            {
                this.servicosModalField = value;
            }
        }
    }
}
