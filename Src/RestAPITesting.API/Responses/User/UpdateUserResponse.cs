using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.User
{
    public class UpdateUserResponse
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("job")]
        public string? Job { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
