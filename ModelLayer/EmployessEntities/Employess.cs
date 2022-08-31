using ModelLayer.ProductsEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.EmployessEntities
{
    public class Employess
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("lastname")]
        public string? LastName { get; set; }
        [JsonProperty("firstname")]
        public string? FirstName { get; set; }
        [JsonProperty("title")]
        public string? Title { get; set; }
        [JsonProperty("titleOfCourtesy")]
        public string? TitleOfCourtesy { get; set; }
        [JsonProperty("birthDate")]
        public string? BirthDate { get; set; }
        [JsonProperty("hireDate")]
        public string? HireDate { get; set; }
        [JsonProperty("address")]
        public Address? Address { get; set; }
        [JsonProperty("notes")]
        public string? Notes { get; set; }
        [JsonProperty("territoryIds")]
        public IList<int>? TerritoryIds { get; set; }
    }
}
