namespace RestAPITesting.ApiData
{
    public class ApiDataUrls
    {
        private static Uri BaseUrl = new("https://reqres.in/");

        public static Models.ApiData LoginApi =>
            new(new Uri(BaseUrl + "api/login"));

        public static Models.ApiData RegisterApi =>
            new(new Uri(BaseUrl + "api/register"));

        public static Models.ApiData UsersApi =>
            new(new Uri(BaseUrl + "api/users"));

        public static Models.ApiData GetSingleUserApi(int id) =>
            new(new Uri(BaseUrl + $"api/users/{id}"));
    }
}
