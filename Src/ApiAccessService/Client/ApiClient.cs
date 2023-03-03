using RestAPITesting.ApiAccessService.Request;
using RestAPITesting.ApiAccessService.Response;
using RestSharp;

namespace RestAPITesting.ApiAccessService.Client
{
    public class ApiClient : IApiClient
    {
        private readonly RestClient _client;

        public ApiClient()
        {
            _client = new RestClient();
        }

        public WrappedResponse<TResponse> SendRequest<TResponse>(WrappedRequest<TResponse> wrappedRequest)
        {
            var request = SetupClientAndCreateRequest(wrappedRequest);
            var response = _client.Execute<TResponse>(request);

            return new WrappedResponse<TResponse>(WrapResponse(response), response.Data);
        }

        private RestRequest SetupClientAndCreateRequest(WrappedRequest wrappedRequest)
        {
            var info = wrappedRequest.Info;
            _client.Options.BaseUrl = info.Url;

            return info.Request;
        }

        private HttpResponseMessage WrapResponse(RestResponse response) =>
            new()
            {
                Content = new StringContent(response.Content),
                StatusCode = response.StatusCode,
                ReasonPhrase = response.StatusDescription,
            };
    }
}
