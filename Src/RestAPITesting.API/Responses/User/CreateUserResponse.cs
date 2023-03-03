using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.User
{
    public class CreateUserResponse
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("job")]
        public string? Job { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
