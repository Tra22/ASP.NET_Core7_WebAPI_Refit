using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.Cart {
    public class ProductCart {
        [JsonPropertyName("productId")]
        public required int ProductId {get;set;}
        [JsonPropertyName("quantity")]
        public required int Quantity {get;set;}
    }
}