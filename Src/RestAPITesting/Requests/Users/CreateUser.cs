namespace RestAPITesting.Requests.Users
{
    public class CreateUser : WrappedRequest<CreateUserResponse>
    {
        private readonly CreateUserDto _user;

        public CreateUser(string name, string job)
        {
            _user = new CreateUserDto(name, job);
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodPost().WithJsonBody(_user);

        protected override Models.ApiData GetApiData() =>
            ApiDataUrls.UsersApi;
    }
}
