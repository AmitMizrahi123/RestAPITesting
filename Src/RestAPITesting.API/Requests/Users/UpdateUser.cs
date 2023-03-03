using RestAPITesting.API.Models;
using RestAPITesting.API.Responses.User;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Users
{
    public class UpdateUser : WrappedRequest<UpdateUserResponse>
    {
        private readonly int _id;
        private readonly UpdateUserDto _user;

        public UpdateUser(int id, string name, string job)
        {
            _id = id;
            _user = new UpdateUserDto(name, job);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPut().WithJsonBody(_user);

        protected override ApiData GetApiData() =>
            ApiDataUrls.GetSingleUserApi(_id);
    }
}
