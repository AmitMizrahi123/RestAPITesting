namespace RestAPITesting.Requests
{
    public abstract class WrappedRequest
    {
        public RestRequestInfo Info => CreateRequest().GetInfo();
        protected abstract RequestBuilder CreateRequest();
        protected abstract Models.ApiData GetApiData();

        protected RequestBuilder GetBuilder()
        {
            var data = GetApiData();

            var builder = RequestBuilder.Create(data);

            return builder;
        }
    }
}
