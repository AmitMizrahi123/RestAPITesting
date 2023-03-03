using RestAPITesting.API.Responses.User;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Users
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

        protected override ApiData GetApiData() =>
            ApiDataUrls.GetSingleUserApi(_id);
    }
}
