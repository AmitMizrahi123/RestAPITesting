namespace RestAPITesting.Models
{
    public class ApiData
    {
        public ApiData(Uri url)
        {
            Url = url;
        }

        public Uri Url { get; set; }
    }
}
