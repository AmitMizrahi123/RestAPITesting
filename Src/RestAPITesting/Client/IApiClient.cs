namespace RestAPITesting.Client
{
    public interface IApiClient
    {
        WrappedResponse<TResponse> SendRequest<TResponse>(WrappedRequest<TResponse> request);
    }
}
