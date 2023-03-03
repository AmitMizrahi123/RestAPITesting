namespace RestAPITesting.Requests.Users
{
    public class GetSingleUser : WrappedRequest<GetSingleUserResponse>
    {
        private readonly int _id;

        public GetSingleUser(int id)
        {
            _id = id;
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodGet();

        protected override Models.ApiData GetApiData() =>
            ApiDataUrls.GetSingleUserApi(_id);
    }
}
