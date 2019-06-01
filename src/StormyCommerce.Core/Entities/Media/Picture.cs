using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Core.Entities.Media
{
    public class Picture : BaseEntity
    {
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public string Url { get; set; }
        public string AltAttribute { get; set; }        
    }
}
