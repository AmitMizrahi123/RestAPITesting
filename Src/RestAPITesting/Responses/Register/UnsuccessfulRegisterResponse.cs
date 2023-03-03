namespace RestAPITesting.Responses.Register
{
    public class UnsuccessfulRegisterResponse
    {
        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}
