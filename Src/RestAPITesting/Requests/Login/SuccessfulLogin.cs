namespace RestAPITesting.Requests.Login
{
    public class SuccessfulLogin
    {
        private readonly string _email;
        private readonly string _password;

        public SuccessfulLogin(string email, string password)
        {
            _email = email;
            _password = password;
        }
    }
}
