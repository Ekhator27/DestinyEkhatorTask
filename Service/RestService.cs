using RestSharp;

namespace TechnicalTest.Service
{
    public class RestService
    {
        public RestResponse Get(string url)
        {
            RestClient restClient = new RestClient();
            var request = new RestRequest(url, Method.Get);
            var restResponse = restClient.Execute(request);

            return restResponse;
        }
    }
}
