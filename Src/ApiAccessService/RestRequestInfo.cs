using RestSharp;

namespace RestAPITesting.ApiAccessService
{
    public class RestRequestInfo
    {
        public RestRequestInfo(Uri url, RestRequest request)
        {
            Url = url;
            Request = request;
        }

        public Uri Url { get; }
        public RestRequest Request { get; }
    }
}
