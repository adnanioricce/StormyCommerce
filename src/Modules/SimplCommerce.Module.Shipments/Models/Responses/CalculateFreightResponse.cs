using System;
using System.Collections.Generic;

namespace SimplCommerce.Module.Shipments.Models.Responses
{
    public class CalculateFreightResponse
    {
        public List<CalculateFreightOptionResponse> Options { get; set; }
    }
}
