namespace RestAPITesting.API.Models
{
    public class UpdateUserDto
    {
        public UpdateUserDto(string? name, string? job)
        {
            Name = name;
            Job = job;
        }

        public string? Name { get; set; }
        public string? Job { get; set; }
    }
}
