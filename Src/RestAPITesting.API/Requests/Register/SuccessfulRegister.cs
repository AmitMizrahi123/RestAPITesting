using RestAPITesting.API.Models;
using RestAPITesting.API.Responses.Register;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Register
{
    public class SuccessfulRegister : WrappedRequest<SuccessfulRegisterResponse>
    {
        private readonly LoginCred _loginCred;

        public SuccessfulRegister(string email, string password)
        {
            _loginCred = new LoginCred(email, password);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPost().WithJsonBody(_loginCred);

        protected override ApiData GetApiData() =>
            ApiDataUrls.RegisterApi;
    }
}
