using NUnit.Framework;
using RestSharp;
using System;
using System.Net;

namespace RestAPI.Utils
{
    public class DeleteMethods
    {
        private readonly RestClient _client;

        public DeleteMethods(RestClient client)
        {
            _client = client;
        }

        public void DeleteBook(int bookId)
        {
            var request = new RestRequest(Constants.DELETE_BOOK_ENDPOINT, Method.DELETE);
            request.AddUrlSegment("bookId", bookId);
            
            var response = _client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NoContent)
                                            .Or.EqualTo(HttpStatusCode.OK) );
            Console.WriteLine($"DELETE: Book{bookId} deleted");
        }
    }
}
