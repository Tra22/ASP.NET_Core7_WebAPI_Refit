using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.User.Address {
    public class GeoLocationDto {
        [JsonPropertyName("lat")]
        public required string Lat {get;set;}
        [JsonPropertyName("long")]
        public required string Long {get;set;}
    }
}