using RestAPITesting.API.Models;
using RestAPITesting.API.Responses.Login;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Login
{
    public class SuccessfulLogin : WrappedRequest<SuccessfulLoginResponse>
    {
        private readonly LoginCred _loginCred;

        public SuccessfulLogin(string email, string password)
        {
            _loginCred = new LoginCred(email, password);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPost().WithJsonBody(_loginCred);

        protected override ApiData GetApiData() => 
            ApiDataUrls.LoginApi;
    }
}
