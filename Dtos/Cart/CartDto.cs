using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.Cart {
    public class CartDto : BaseCart {
        [JsonPropertyName("id")]
        public required int Id {get;set;}
    }
}