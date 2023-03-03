using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.Register
{
    public class SuccessfulRegisterResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }
    }
}
