using System.Text.Json.Serialization;
using ASP.NET_Core7_WebAPI_Refit.Dtos.User.Address;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.User {
    public class BaseUser {
        [JsonPropertyName("address")]
        public required AddressDto AddressDto {get;set;}
        [JsonPropertyName("email")]
        public required string Email {get;set;}
        public required string Username {get;set;}
        public required string Password {get;set;}
        [JsonPropertyName("name")]
        public required NameDto NameDto {get;set;}
        [JsonPropertyName("phone")]
        public required string Phone {get;set;}
    }
}