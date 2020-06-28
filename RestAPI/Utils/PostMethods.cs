using Newtonsoft.Json.Linq;
using RestAPI.Models;
using RestSharp;
using System;

namespace RestAPI.Utils
{
    public class PostMethods
    {
        private readonly RestClient _client;

        public PostMethods(RestClient client)
        {
            _client = client;
        }

        public JObject CreateHousehold(string name)
        {
            var household = new Household() { Name = name };
            var request = new RestRequest(Constants.HOUSEHOLDS_ENDPOINT, Method.POST);                        
            request.AddJsonBody(household.ToJson(),"application/json");

            var response = _client.Execute<Household>(request);
            var json = JObject.Parse(response.Content);
            Console.WriteLine("Household created: \n" + json);

            return json;
        }

        public JObject CreateUser(User user)
        {            
            var request = new RestRequest(Constants.USERS_ENDPOINT, Method.POST);
            request.AddJsonBody(user.ToJson(), "application/json");

            var response = _client.Execute<User>(request);
            var json = JObject.Parse(response.Content);
            Console.WriteLine("User created: \n" + json);

            return json;
        }
    }
}
