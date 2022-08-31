using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.CategoriesEntities;
using Newtonsoft.Json;

namespace ModelLayer.ProductsEntities
{
    public class Products
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("supplierId")]
        public int SupplierId { get; set; }
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
        [JsonProperty("quantityPerUnit")]
        public string? QuantityPerUnit { get; set; }
        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }
        [JsonProperty("unitInStock")]
        public int UnitsInStock { get; set; }
        [JsonProperty("unitsOnOrder")]
        public int UnitsOnOrder { get; set; }
        [JsonProperty("reorderLevel")]
        public int ReorderLevel { get; set; }
        [JsonProperty("discontiuned")]
        public bool Discontinued { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("supplier")]
        public Supplier? Supplier { get; set; }
        [JsonProperty("category")]
        public Category? Category { get; set; }

    }
}
