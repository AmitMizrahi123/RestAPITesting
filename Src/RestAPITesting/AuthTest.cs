using RestAPITesting.Requests.Register;

namespace RestAPITesting
{
    public class Tests
    {
        private readonly ApiClient _apiClient;

        public Tests()
        {
            _apiClient = new ApiClient();
        }

        [Test]
        public void SuccessfulLoginTest()
        {
            var request = new SuccessfulLogin("eve.holt@reqres.in", "cityslicka");
            var response = _apiClient.SendRequest(request);

            Assert.That(response.Data.Token == "QpwL5tke4Pnpja7X4", "Login response error!");
        }

        [Test]
        public void UnsuccessfulLoginTest()
        {
            var request = new UnsuccessfulLogin("eve.holt@reqres.in");
            var response = _apiClient.SendRequest(request);

            Assert.That(response.Data.Error == "Missing password", "Login response error!");
        }

        [Test]
        public void SuccessfulRegisterTest()
        {
            var request = new SuccessfulRegister("eve.holt@reqres.in", "pistol");
            var response = _apiClient.SendRequest(request);

            Assert.That(response.Data.Id == 4, "Login response error!");
            Assert.That(response.Data.Token == "QpwL5tke4Pnpja7X4", "Login response error!");
        }

        [Test]
        public void UnsuccessfulRegisterTest()
        {
            var request = new UnsuccessfulRegister("eve.holt@reqres.in");
            var response = _apiClient.SendRequest(request);

            Assert.That(response.Data.Error == "Missing password", "Login response error!");
        }
    }
}