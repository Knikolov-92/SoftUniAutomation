using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestAPI.Models;
using RestAPI.Utils;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RestAPI.Tests
{
    [TestFixture]
    public class FirstCollection
    {
        private RestClient _client;
        private GeneralMethods _gen;
        private PostMethods _post;
        private GetMethods _get;
        private JObject _response;
        private Random _random;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient
            {
                BaseUrl = new Uri(Constants.API_BASE_URL)
            };
            _client.AddDefaultHeader(Constants.G_TOKEN_NAME, Constants.G_TOKEN_VALUE);
            _gen = new GeneralMethods();
            _post = new PostMethods(_client);
            _get = new GetMethods(_client);
            _random = new Random();
        }

        [Test]
        public void CorrectWishlistForHouseholdIsReturned_When_CreatingHouseholdWithTwoUsers()
        {
            //arrange
            int householdId;
            string householdName = "Ivanovi";
            var vanio = new User(){Email = "sofia@bulgaria.com", FirstName = "Ivan", LastName = "Ivanov"};
            var mimi = new User(){Email = "plovdiv@bulgaria.com", FirstName = "Maria", LastName = "Ivanova"};            
            List<int> bookIds = new List<int>();
            var badBook = new Book() { Title = "Bad Book", Author = "Bad Author", Isbn = "0001110001", PublicationDate = "1001-01-01" };
            var normalBook = new Book() { Title = "Normal Book", Author = "Normal Author", Isbn = "1110001110", PublicationDate = "1010-10-10" };
            var goodBook = new Book() { Title = "Good Book", Author = "Good Author", Isbn = "0000000000", PublicationDate = "1999-09-09" };
            var excellentBook = new Book() { Title = "Excellent Book", Author = "Excellent Author", Isbn = "1111111111", PublicationDate = "1111-11-11" };

            //act
            //create household and get ID
            _response = _post.CreateHousehold(householdName);
            householdId = _gen.GetIdFromResponse(_response);

            //create users and get WishlistIDs
            vanio.HouseholdID = householdId;
            _response = _post.CreateUser(vanio);
            vanio.WishlistID = _gen.GetWishlistIdFromUser(_response);

            mimi.HouseholdID = householdId;
            _response = _post.CreateUser(mimi);
            mimi.WishlistID = _gen.GetWishlistIdFromUser(_response);

            //create books and get IDs
            _response = _post.CreateBook(badBook);
            badBook.Id = _gen.GetIdFromResponse(_response);

            _response = _post.CreateBook(normalBook);
            normalBook.Id = _gen.GetIdFromResponse(_response);

            _response = _post.CreateBook(goodBook);
            goodBook.Id = _gen.GetIdFromResponse(_response);

            _response = _post.CreateBook(excellentBook);
            excellentBook.Id = _gen.GetIdFromResponse(_response);

            //add books to users' wishlists
            _post.AddBookToUserWishlist(vanio.WishlistID, badBook.Id);
            _post.AddBookToUserWishlist(vanio.WishlistID, normalBook.Id);
            _post.AddBookToUserWishlist(mimi.WishlistID, goodBook.Id);
            _post.AddBookToUserWishlist(mimi.WishlistID, excellentBook.Id);

            //get wishlist of household
            var householdWishlist = _get.GetWishlistOfHousehold(householdId);
            var bookOnWishlist = _gen.GetJsonObjectFromJarray(householdWishlist, 0);
            string expectedBookTitle = "Don't Waste Your Life";
            string actualBookTitle = _gen.GetJSONstringValue(bookOnWishlist, "title");

            //assert
            Assert.Multiple(() =>
            {
                Assert.That(actualBookTitle, Is.EqualTo(expectedBookTitle));
                Assert.That(householdWishlist.Count, Is.EqualTo(2));
            });

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
