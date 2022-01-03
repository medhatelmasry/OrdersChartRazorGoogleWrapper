using System.Text.Json.Serialization;

namespace OrdersChartRazorGoogleWrapper.Models
{
    public class Order
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }


        [JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }


        [JsonPropertyName("employeeId")]
        public int? EmployeeId { get; set; }


        [JsonPropertyName("shipVia")]
        public int? ShipVia { get; set; }


        [JsonPropertyName("freight")]
        public decimal? Freight { get; set; }


        [JsonPropertyName("shipName")]
        public string? ShipName { get; set; }


        [JsonPropertyName("shipAddress")]
        public Address ShipAddress { get; set; } = null!;
    }

}