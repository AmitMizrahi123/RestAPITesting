using RestAPITesting.ApiAccessService.Request;
using RestAPITesting.ApiAccessService.Response;

namespace RestAPITesting.ApiAccessService.Client
{
    public interface IApiClient
    {
        WrappedResponse<TResponse> SendRequest<TResponse>(WrappedRequest<TResponse> request);
    }
}
