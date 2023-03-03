using RestAPITesting.API.Models;
using RestAPITesting.API.Responses.User;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Users
{
    public class CreateUser : WrappedRequest<CreateUserResponse>
    {
        private readonly CreateUserDto _user;

        public CreateUser(string name, string job)
        {
            _user = new CreateUserDto(name, job);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPost().WithJsonBody(_user);

        protected override ApiData GetApiData() =>
            ApiDataUrls.UsersApi;
    }
}
