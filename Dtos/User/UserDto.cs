using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Dtos.User {
    public class UserDto : BaseUser{
        [JsonPropertyName("id")]
        public required int Id {get;set;}
    }
}