namespace RestAPITesting.Requests.Login
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

        protected override Models.ApiData GetApiData() => 
            ApiDataUrls.LoginApi;
    }
}
