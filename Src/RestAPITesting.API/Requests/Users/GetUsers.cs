using RestAPITesting.API.Responses.User;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Users
{
    public class GetUsers : WrappedRequest<GetUsersResponse>
    {
        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodGet().WithParameters(("page", 2));

        protected override ApiData GetApiData() =>
            ApiDataUrls.UsersApi;
    }
}
