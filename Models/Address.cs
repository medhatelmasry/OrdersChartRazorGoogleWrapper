using System.Text.Json.Serialization;

namespace OrdersChartRazorGoogleWrapper.Models
{
    public class Address
    {
        [JsonPropertyName("street")]
        public string? Street { get; set; }


        [JsonPropertyName("city")]
        public string? City { get; set; }


        [JsonPropertyName("region")]
        public string? Region { get; set; }


        [JsonPropertyName("country")]
        public string? Country { get; set; }

    }

}