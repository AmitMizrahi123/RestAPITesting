using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.Login
{
    public class SuccessfulLoginResponse
    {
        [JsonProperty("token")]
        public string? Token { get; set; }
    }
}
