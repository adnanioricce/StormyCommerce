using System;
using System.Collections.Generic;
using System.Text;

namespace SimplCommerce.Module.Correios.Models
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
