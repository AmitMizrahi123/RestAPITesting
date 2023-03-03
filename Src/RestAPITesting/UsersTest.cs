namespace RestAPITesting
{
    public class UsersTest
    {
        private readonly ApiClient _apiClient;

        public UsersTest()
        {
            _apiClient = new ApiClient();
        }

        [Test]
        public void GetUsersTests()
        {
            var request = new GetUsers();
            var response = _apiClient.SendRequest(request);

            Assert.That(response.Data.Page == 2, "Page number error!");
            Assert.That(response.Data.Total == 12, "Total page number error!");
        }

        [Test]
        public void GetSingleUserTests()
        {
            var request = new GetSingleUser(2);
            var response = _apiClient.SendRequest(request);

            Assert.That(response.Data.Data.Id == 2, "Page number error!");
            Assert.That(response.Data.Data.Email == "janet.weaver@reqres.in", "Page number error!");
        }

        [Test]
        public void NegativeGetSingleUserTests()
        {
            var request = new GetSingleUser(23);
            var response = _apiClient.SendRequest(request);

            Assert.That(response.IsSuccessStatusCode == false, "The user found with 23 id");
        }

        [Test]
        public void CreateUserTests()
        {
            var request = new CreateUser("morpheus", "leader");
            var response = _apiClient.SendRequest(request);

            Assert.IsNotEmpty(response.Data.Id, "User not created");
        }
    }
}