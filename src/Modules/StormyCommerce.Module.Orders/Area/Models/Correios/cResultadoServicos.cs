using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models.Correios
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public partial class cResultadoServicos
    {

        private cServicosCalculo[] servicosCalculoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public cServicosCalculo[] ServicosCalculo
        {
            get
            {
                return this.servicosCalculoField;
            }
            set
            {
                this.servicosCalculoField = value;
            }
        }
    }
}
