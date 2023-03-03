using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.User
{
    public class GetSingleUserResponse
    {
        [JsonProperty("data")]
        public SharedResponse.Datum Data { get; set; }

        [JsonProperty("support")]
        public SharedResponse.Support Support { get; set; }
    }
}
