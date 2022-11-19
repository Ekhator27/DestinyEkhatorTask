using RestSharp;
using TechnicalTest.Service;

namespace TechnicalTest
{
    public class LocationClient
    {
        private readonly RestService _resrService;
        private readonly ConfigurationProvider _configurationProvider;
        private RestResponse Response;
        private string url;
        public LocationClient(RestService restService, ConfigurationProvider configurationProvider)
        {
            _resrService = restService;
            _configurationProvider = configurationProvider;
        }

        public void GetLocationInformation(string countryCode, string postCode)
        {
            url = string.Format(_configurationProvider.GetUrl(), countryCode, postCode);
            Response = _resrService.Get(url);
        }

        public bool VerifyRequestStatus(string isSuccessful)
        {
            if (Response.IsSuccessful.ToString().ToLower().Equals(isSuccessful))
                return bool.Parse(isSuccessful);
            return true;
        }
    }
}
