namespace RestAPITesting.Responses.Login
{
    public class UnsuccessfulLoginResponse
    {
        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}
