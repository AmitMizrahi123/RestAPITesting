using System.Net;

namespace RestAPITesting.ApiAccessService.Response
{
    public class WrappedResponse
    {
        private readonly HttpResponseMessage _response;
        public WrappedResponse(HttpResponseMessage response)
        {
            _response = response;
        }

        public bool IsSuccessStatusCode => _response.IsSuccessStatusCode;

        public HttpStatusCode StatusCode => _response.StatusCode;

        public string Content => _response.Content.ReadAsStringAsync().Result;
    }
}