using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.Register
{
    public class UnsuccessfulRegisterResponse
    {
        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}
