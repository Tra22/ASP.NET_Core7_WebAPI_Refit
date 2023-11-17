using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.Product {
    public class RatingDto {
        [JsonPropertyName("rate")]
        public required decimal Rate {get;set;}
        [JsonPropertyName("count")]
        public required int Count {get;set;}
    }
}