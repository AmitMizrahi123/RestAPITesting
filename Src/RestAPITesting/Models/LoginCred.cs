namespace RestAPITesting.Models
{
    public class LoginCred
    {
        public LoginCred(string email)
        {
            Email = email;
        }

        public LoginCred(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
