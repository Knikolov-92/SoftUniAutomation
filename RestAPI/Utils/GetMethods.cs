using RestSharp;


namespace RestAPI.Utils
{
    public class GetMethods
    {
        private readonly RestClient _client;

        public GetMethods(RestClient client)
        {
            _client = client;
        }
    }
}
