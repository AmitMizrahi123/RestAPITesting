namespace RestAPITesting.API.Models
{
    public class LoginCredDto
    {
        public LoginCredDto(string email)
        {
            Email = email;
        }

        public LoginCredDto(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
