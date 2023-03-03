namespace RestAPITesting.Models
{
    public class CreateUserDto
    {
        public CreateUserDto(string? name, string? job)
        {
            Name = name;
            Job = job;
        }

        public string? Name { get; set; }
        public string? Job { get; set; }
    }
}
