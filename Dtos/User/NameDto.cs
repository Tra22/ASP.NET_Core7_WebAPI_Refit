using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.User {
    public class NameDto {
        [JsonPropertyName("firstname")]
        public required string FirstName {get;set;}
        [JsonPropertyName("lastname")]
        public required string LastName {get;set;}
    }
}