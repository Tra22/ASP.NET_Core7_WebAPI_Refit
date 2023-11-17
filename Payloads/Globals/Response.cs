namespace ASP.NET_Core7_WebAPI_Refit.Payloads.Globals {
    public class Response<T>
    {

        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string? Message { get; set; } = null;
        public string? Error { get; set; } = null;
        public List<string>? ErrorMessages { get; set; } = null;
    }
}