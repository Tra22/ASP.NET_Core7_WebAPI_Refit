using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.Product {
    public class ProductDto : BaseProduct {
        [JsonPropertyName("id")]
        public required int Id {get;set;}
    }
}