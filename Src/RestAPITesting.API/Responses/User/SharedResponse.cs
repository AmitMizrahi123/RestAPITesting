using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.User
{
    public class SharedResponse
    {
        public class Datum
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("first_name")]
            public string FirstName { get; set; }

            [JsonProperty("last_name")]
            public string LastName { get; set; }

            [JsonProperty("avatar")]
            public Uri Avatar { get; set; }
        }

        public class Support
        {
            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }
        }
    }
}
