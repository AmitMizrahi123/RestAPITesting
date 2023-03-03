namespace RestAPITesting.Requests.Login
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

        protected override Models.ApiData GetApiData() => 
            ApiDataUrls.LoginApi;
    }
}
