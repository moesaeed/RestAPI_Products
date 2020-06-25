using Newtonsoft.Json;
using RestAPI_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI_Core.Contracts
{
    public class ProductResponse
    {
        public ProductResponse()
        {
            Products = new List<Product>();
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        public List<Product> Products { get; set; }
    }
}
