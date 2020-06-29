using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace RestAPI.Utils
{
    public class GetMethods
    {
        private readonly RestClient _client;

        public GetMethods(RestClient client)
        {
            _client = client;
        }

        public JArray GetWishlistOfHousehold(int householdId)
        {
            var request = new RestRequest(Constants.HOUSEHOLD_WISHLIST_ENDPOINT, Method.GET);
            request.AddUrlSegment("householdId", householdId);

            var response = _client.Execute(request);
            var json = JArray.Parse(response.Content);

            Console.WriteLine($"GET: wishlist of household({householdId}): \n" + json);

            return json;
        }
    }
}
