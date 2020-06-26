using NUnit.Framework;
using RestAPI.Utils;
using RestSharp;
using System;


namespace RestAPI.Tests
{
    [TestFixture]
    public class FirstCollection
    {
        private RestClient _client;
        private PostMethods _post;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient();
            _client.BaseUrl = new Uri(Constants.API_BASE_URL);
            _client.AddDefaultHeader(Constants.G_TOKEN_NAME, Constants.G_TOKEN_VALUE);
            _post = new PostMethods(_client);
        }

        [Test]
        public void CorrectWishlistForHouseholdIsReturned_When_CreatingHouseholdWithTwoUsers()
        {
            int hhId = 0;
            var response = _post.CreateHousehold("Von Habsburg");
            hhId = response.Data.Id;
            //CreateHousehold(name);
            //CreateUser();
            //CreateUser();
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
