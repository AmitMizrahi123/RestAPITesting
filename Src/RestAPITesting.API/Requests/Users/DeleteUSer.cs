using RestAPITesting.API.Models;
using RestAPITesting.ApiAccessService;
using RestAPITesting.ApiAccessService.ApiData;
using RestAPITesting.ApiAccessService.Models;
using RestAPITesting.ApiAccessService.Request;

namespace RestAPITesting.API.Requests.Users
{
    public class DeleteUSer : WrappedRequest<UpdateUserDto>
    {
        private readonly int _id;

        public DeleteUSer(int id)
        {
            _id = id;
        }

        protected override RequestBuilder CreateRequest() =>
            GetBuilder().MethodDelete();

        protected override ApiData GetApiData() =>
            ApiDataUrls.GetSingleUserApi(_id);
    }
}
