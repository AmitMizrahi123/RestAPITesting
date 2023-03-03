namespace RestAPITesting.Requests.Register
{
    public class UnsuccessfulRegister : WrappedRequest<UnsuccessfulRegisterResponse>
    {
        private readonly LoginCred _loginCred;

        public UnsuccessfulRegister(string email)
        {
            _loginCred = new LoginCred(email);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPost().WithJsonBody(_loginCred);

        protected override Models.ApiData GetApiData() =>
            ApiDataUrls.RegisterApi;
    }
}
