using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.User.Address {
    public class AddressDto {
        [JsonPropertyName("geolocation")]
        public required GeoLocationDto GeoLocationDto {get;set;}
        [JsonPropertyName("city")]
        public required string City {get;set;}
        [JsonPropertyName("street")]
        public required string Street {get;set;}
        [JsonPropertyName("number")]
        public required int Number {get;set;}
        [JsonPropertyName("zipcode")]
        public required string ZipCode {get;set;}
    }
}