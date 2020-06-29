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
            Console.WriteLine("POST: Household created: \n" + json);

            return json;
        }

        public JObject CreateUser(User user)
        {            
            var request = new RestRequest(Constants.USERS_ENDPOINT, Method.POST);
            request.AddJsonBody(user.ToJson(), "application/json");

            var response = _client.Execute<User>(request);
            var json = JObject.Parse(response.Content);
            Console.WriteLine("POST: User created: \n" + json);

            return json;
        }

        public JObject CreateBook(Book book)
        {
            var request = new RestRequest(Constants.BOOKS_ENDPOINT, Method.POST);
            request.AddJsonBody(book.ToJson(), "application/json");

            var response = _client.Execute<Book>(request);
            var json = JObject.Parse(response.Content);
            Console.WriteLine("POST: Book created: \n" + json);

            return json;
        }

        public void AddBookToUserWishlist(int wishlistId, int bookId)
        {
            var request = new RestRequest(Constants.ADD_BOOK_TO_WISHLIST_ENDPOINT, Method.POST);
            request.AddUrlSegment("wishlistId", wishlistId);
            request.AddUrlSegment("bookId", bookId);

            var response = _client.Execute(request);            
            Console.WriteLine($"POST: add book({bookId}) to wishlist({wishlistId}) \n response: " + response.StatusCode);            
        }
    }
}
