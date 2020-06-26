using RestAPI.Models;
using RestSharp;


namespace RestAPI.Utils
{
    public class PostMethods
    {
        private RestClient _client;

        public PostMethods(RestClient client)
        {
            _client = client;
        }

        public IRestResponse<Household> CreateHousehold(string name)
        {
            var household = new Household() { Name = name };
            var request = new RestRequest("households", Method.POST);                        
            request.AddJsonBody(household.ToJson(),"application/json");

            IRestResponse<Household> response = _client.Execute<Household>(request);

            return response;
        }
    }
}
