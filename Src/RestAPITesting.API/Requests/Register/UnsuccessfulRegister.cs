using RestAPITesting.API.Models;
using RestAPITesting.API.Responses.Register;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Register
{
    public class UnsuccessfulRegister : WrappedRequest<UnsuccessfulRegisterResponse>
    {
        private readonly LoginCredDto _loginCred;

        public UnsuccessfulRegister(string email)
        {
            _loginCred = new LoginCredDto(email);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPost().WithJsonBody(_loginCred);

        protected override ApiData GetApiData() =>
            ApiDataUrls.RegisterApi;
    }
}
