namespace RestAPITesting.Requests.Login
{
    public class UnsuccessfulLogin
    {
        private readonly string _email;

        public UnsuccessfulLogin(string email, string password)
        {
            _email = email;
        }
    }
}
