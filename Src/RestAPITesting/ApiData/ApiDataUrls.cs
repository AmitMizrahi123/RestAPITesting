namespace RestAPITesting.ApiData
{
    public class ApiDataUrls
    {
        private static Uri BaseUrl = new("https://reqres.in/");

        public static Models.ApiData LoginApi =>
            new(new Uri(BaseUrl + "api/login"));

        public static Models.ApiData RegisterApi =>
            new(new Uri(BaseUrl + "api/register"));
    }
}
