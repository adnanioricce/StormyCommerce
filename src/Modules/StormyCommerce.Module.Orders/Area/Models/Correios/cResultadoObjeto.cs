using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models.Correios
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public partial class cResultadoObjeto
    {

        private cObjeto[] objetosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public cObjeto[] Objetos
        {
            get
            {
                return this.objetosField;
            }
            set
            {
                this.objetosField = value;
            }
        }
    }
}
