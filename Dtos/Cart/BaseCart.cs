using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.Cart {
    public class BaseCart {
        [JsonPropertyName("userId")]
        public required int UserId {get;set;}
        [JsonPropertyName("date")]
        public required DateTime Date {get;set;}
        [JsonPropertyName("products")]
        public required List<ProductCart> ProductCart {get;set;}
    }
}