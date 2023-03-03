namespace RestAPITesting.Requests.Users
{
    public class GetUsers : WrappedRequest<GetUsersResponse>
    {
        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodGet().WithParameters(("page", 2));

        protected override Models.ApiData GetApiData() =>
            ApiDataUrls.UsersApi;
    }
}
