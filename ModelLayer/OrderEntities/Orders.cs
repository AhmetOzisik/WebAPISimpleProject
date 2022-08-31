using ModelLayer.OrderEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Entities
{
    public class Orders
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("customerId")]
        public string? CustomerId { get; set; }
        [JsonProperty("employeeId")]
        public int EmployeeId { get; set; }
        [JsonProperty("orderDate")]
        public string? OrderDate { get; set; }
        [JsonProperty("requiredDate")]
        public string? RequiredDate { get; set; }
        [JsonProperty("shippedDate")]
        public string? ShippedDate { get; set; }
        [JsonProperty("shipVia")]
        public int ShipVia { get; set; }
        [JsonProperty("freight")]
        public double Freight { get; set; }
        [JsonProperty("shipName")]
        public string? ShipName { get; set; }
        [JsonProperty("shipAddress")]
        public ShipAddress? ShipAddress { get; set; }
        [JsonProperty("details")]
        public List<Details>? Details { get; set; }
    }
}
