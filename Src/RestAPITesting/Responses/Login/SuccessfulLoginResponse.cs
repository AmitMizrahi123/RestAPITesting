namespace RestAPITesting.Responses.Login
{
    public class SuccessfulLoginResponse
    {
        [JsonProperty("token")]
        public string? Token { get; set; }
    }
}
