using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.Login
{
    public class UnsuccessfulLoginResponse
    {
        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}
