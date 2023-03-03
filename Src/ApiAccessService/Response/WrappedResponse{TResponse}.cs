namespace RestAPITesting.ApiAccessService.Response
{
    public class WrappedResponse<TResponse> : WrappedResponse
    {
        public WrappedResponse(HttpResponseMessage response, TResponse data)
            : base(response)
        {
            Data = data;
        }

        public TResponse Data { get; }
    }
}
