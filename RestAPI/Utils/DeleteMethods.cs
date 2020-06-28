using RestSharp;


namespace RestAPI.Utils
{
    public class DeleteMethods
    {
        private readonly RestClient _client;

        public DeleteMethods(RestClient client)
        {
            _client = client;
        }
    }
}
