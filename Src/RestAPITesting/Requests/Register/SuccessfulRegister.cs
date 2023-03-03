namespace RestAPITesting.Requests.Register
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

        protected override Models.ApiData GetApiData() =>
            ApiDataUrls.RegisterApi;
    }
}
