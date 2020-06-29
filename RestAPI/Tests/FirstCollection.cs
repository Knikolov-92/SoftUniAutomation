using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestAPI.Models;
using RestAPI.Utils;
using RestSharp;
using RestSharp.Authenticators;
using System;

namespace RestAPI.Tests
{
    [TestFixture]
    public class FirstCollection
    {
        private RestClient _client;
        private GeneralMethods _gen;
        private PostMethods _post;
        private GetMethods _get;
        private DeleteMethods _del;
        private JObject _response;
        private int _badBookId;
        private int _averageBookId;
        private int _goodBookId;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient
            {
                BaseUrl = new Uri(Constants.API_BASE_URL)
            };
            _client.AddDefaultHeader(Constants.G_TOKEN_NAME, Constants.G_TOKEN_VALUE);
            _client.Authenticator = new HttpBasicAuthenticator(Constants.AUTHORIZATION_NAME, Constants.AUTHORIZATION_PASSWORD);
            _gen = new GeneralMethods();
            _post = new PostMethods(_client);
            _get = new GetMethods(_client);
            _del = new DeleteMethods(_client);
        }

        [Test]
        public void CorrectWishlistForHouseholdIsReturned_When_CreatingHouseholdWithTwoUsers()
        {
            //arrange-------------------------------------------------------------------------------------------------------
            int householdId;
            string householdName = "Ivanovi";
            var vanio = new User() { Email = "sofia@bulgaria.com", FirstName = "Ivan", LastName = "Ivanov" };
            var mimi = new User() { Email = "plovdiv@bulgaria.com", FirstName = "Maria", LastName = "Ivanova" };
            var badBook = new Book() { Title = "Bad Book", Author = "Bad Author", Isbn = "0101010101", PublicationDate = "1001-01-01" };
            var averageBook = new Book() { Title = "Average Book", Author = "Average Author", Isbn = "1010101010", PublicationDate = "1010-10-10" };
            var goodBook = new Book() { Title = "Good Book", Author = "Good Author", Isbn = "1111111111", PublicationDate = "1111-11-11" };
            int startIndex = 0;          

            //act-----------------------------------------------------------------------------------------------------------
            //create household and get its ID
            _response = _post.CreateHousehold(householdName);
            householdId = _gen.GetIdFromResponse(_response);

            //create users and get their WishlistIDs
            vanio.HouseholdID = householdId;
            _response = _post.CreateUser(vanio);
            vanio.WishlistID = _gen.GetWishlistIdFromUser(_response);

            mimi.HouseholdID = householdId;
            _response = _post.CreateUser(mimi);
            mimi.WishlistID = _gen.GetWishlistIdFromUser(_response);

            //create books and get their IDs
            _response = _post.CreateBook(badBook);
            badBook.Id = _gen.GetIdFromResponse(_response);

            _response = _post.CreateBook(averageBook);
            averageBook.Id = _gen.GetIdFromResponse(_response);

            _response = _post.CreateBook(goodBook);
            goodBook.Id = _gen.GetIdFromResponse(_response);            

            //add books to users' wishlists
            _post.AddBookToUserWishlist(vanio.WishlistID, badBook.Id);
            _post.AddBookToUserWishlist(vanio.WishlistID, averageBook.Id);
            _post.AddBookToUserWishlist(mimi.WishlistID, averageBook.Id);
            _post.AddBookToUserWishlist(mimi.WishlistID, goodBook.Id);

            //get wishlist of household
            var householdWishlist = _get.GetHouseholdWishlist(householdId);            
            _badBookId = badBook.Id;
            _averageBookId = averageBook.Id;
            _goodBookId = goodBook.Id;

            //assert--------------------------------------------------------------------------------------------------------
            //check that the three newly created books are added to household's wishlist
            if(_gen.AssertHoseholdWishlistHasCorrectSize(householdWishlist).Equals(true))
            {
                _gen.AssertBookIsContainedInHouseholdWishlist(badBook, householdWishlist, startIndex);
                _gen.AssertBookIsContainedInHouseholdWishlist(averageBook, householdWishlist, startIndex + 1);
                _gen.AssertBookIsContainedInHouseholdWishlist(goodBook, householdWishlist, startIndex + 2);
            }
            else
            {
                Assert.Fail($"ERROR, no wishlist for household with ID = {householdId} is retrieved");
            }            
        }

        [TearDown]
        public void CleanUp()
        {
            _del.DeleteBook(_badBookId);
            _del.DeleteBook(_averageBookId);
            _del.DeleteBook(_goodBookId);
        }
    }
}
