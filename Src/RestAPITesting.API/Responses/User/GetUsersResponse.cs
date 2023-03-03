using Newtonsoft.Json;

namespace RestAPITesting.API.Responses.User
{
    public class GetUsersResponse
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("data")]
        public SharedResponse.Datum[] Data { get; set; }

        [JsonProperty("support")]
        public SharedResponse.Support Support { get; set; }
    }
}
