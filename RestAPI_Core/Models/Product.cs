using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI_Core.Models
{
    public class Product
    {
        [JsonIgnore]
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
