using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.Product {
    public class BaseProduct {
        [JsonPropertyName("title")]
        public required string Title {get;set;}
        [JsonPropertyName("price")]
        public required decimal Price {get;set;}
        [JsonPropertyName("description")]
        public required string Description {get;set;}
        [JsonPropertyName("category")]
        public required string Category {get;set;}
        [JsonPropertyName("image")]
        public required string Image {get;set;}
        [JsonPropertyName("rating")]
        public required RatingDto RatingDto {get;set;}
    }
}