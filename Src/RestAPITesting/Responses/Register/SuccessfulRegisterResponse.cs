﻿namespace RestAPITesting.Responses.Register
{
    public class SuccessfulRegisterResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }
    }
}
