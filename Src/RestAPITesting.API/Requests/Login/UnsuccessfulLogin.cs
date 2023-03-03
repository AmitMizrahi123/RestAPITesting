using RestAPITesting.API.Models;
using RestAPITesting.API.Responses.Login;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Login
{
    public class UnsuccessfulLogin : WrappedRequest<UnsuccessfulLoginResponse>
    {
        private readonly LoginCred _loginCred;

        public UnsuccessfulLogin(string email)
        {
            _loginCred = new LoginCred(email);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPost().WithJsonBody(_loginCred);

        protected override ApiData GetApiData() => 
            ApiDataUrls.LoginApi;
    }
}
