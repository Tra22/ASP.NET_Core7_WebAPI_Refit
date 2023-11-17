using System.Text.Json.Serialization;

namespace ASP.NET_Core7_WebAPI_Refit.Payloads.Requests.Cart {
    public class QueryParamCart : QueryParam {
        [JsonPropertyName("startdate")]
        public string? StartDate {get;set;}
        [JsonPropertyName("enddate")]
        public string? EndDate {get;set;}
    }
}