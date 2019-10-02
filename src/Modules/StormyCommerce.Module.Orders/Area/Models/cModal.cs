using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public partial class cModal
    {

        private string codigoField;

        private string modalField;

        private string obsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string codigo
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
        public string modal
        {
            get
            {
                return this.modalField;
            }
            set
            {
                this.modalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string obs
        {
            get
            {
                return this.obsField;
            }
            set
            {
                this.obsField = value;
            }
        }
    }
}
