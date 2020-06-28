using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestAPI.Models;
using RestAPI.Utils;
using RestSharp;
using System;


namespace RestAPI.Tests
{
    [TestFixture]
    public class FirstCollection
    {
        private RestClient _client;
        private GeneralMethods _gen = new GeneralMethods();
        private PostMethods _post;
        private JObject _response;        

        [SetUp]
        public void Setup()
        {
            _client = new RestClient
            {
                BaseUrl = new Uri(Constants.API_BASE_URL)
            };
            _client.AddDefaultHeader(Constants.G_TOKEN_NAME, Constants.G_TOKEN_VALUE);
            _post = new PostMethods(_client);
        }

        [Test]
        public void CorrectWishlistForHouseholdIsReturned_When_CreatingHouseholdWithTwoUsers()
        {
            //arrange
            int householdId;
            int vanioId;
            int mimiId;
            string householdName = "Ivanovi";
            var vanio = new User()
            {
                Email = "sofia@bulgaria.com",
                FirstName = "Ivan",
                LastName = "Ivanov"
            };
            var mimi = new User()
            {
                Email = "plovdiv@bulgaria.com",
                FirstName = "Maria",
                LastName = "Ivanova"
            };

            //act
            _response = _post.CreateHousehold(householdName);
            householdId = _gen.GetJSONintValue(_response, "id");

            vanio.HouseholdID = householdId;
            _response = _post.CreateUser(vanio);
            vanioId = _gen.GetJSONintValue(_response, "id");


            //assert

            
            //AddBookToUserWishlist();
            //AddBookToUserWishlist();
            //AddBookToUserWishlist();
            //AddBookToUserWishlist();
            //GetHouseholdWishlist();
            //AssertCorrectHouseHoldWishlistIsReturned();
        }

        [TearDown]
        public void CleanUp()
        {

        }
    }
}
