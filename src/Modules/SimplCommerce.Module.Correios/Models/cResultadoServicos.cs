using System;
using System.Collections.Generic;
using System.Text;

namespace SimplCommerce.Module.Correios.Models
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
