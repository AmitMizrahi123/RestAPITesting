using RestSharp;

namespace RestAPITesting.ApiAccessService
{
    public class RequestBuilder
    {
        private readonly Uri _url;
        private readonly RestRequest _request;

        private RequestBuilder(Uri url)
        {
            _url = url;
            _request = new RestRequest(_url);
        }

        internal static RequestBuilder Create(Models.ApiData data) => new(data.Url);

        public RequestBuilder MethodGet()
        {
            _request.Method = Method.Get;
            return this;
        }

        public RequestBuilder MethodPost()
        {
            _request.Method = Method.Post;
            return this;
        }

        public RequestBuilder MethodPut()
        {
            _request.Method = Method.Put;
            return this;
        }

        public RequestBuilder WithJsonBody<T>(T dto) 
            where T : class
        {
            _request.AddJsonBody(dto);
            return this;
        }

        public RequestBuilder WithParameters(params (string key, object value)[] parameters)
        {
            foreach (var (key, value) in parameters)
            {
                _request.AddQueryParameter(key, value.ToString());
            }

            return this;
        }

        public RestRequestInfo GetInfo() => new(_url, _request);
    }
}
