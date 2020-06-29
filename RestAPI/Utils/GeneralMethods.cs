using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestAPI.Models;
using System;

namespace RestAPI.Utils
{
    public class GeneralMethods
    {
        public GeneralMethods()
        { }

        public string GetJSONstringValue(JObject jsonObject, string jsonKey)
        {
            return jsonObject.GetValue(jsonKey).ToString();
        }

        public int GetJSONintValue(JObject jsonObject, string jsonKey)
        {
            var jsonVal = jsonObject.GetValue(jsonKey).ToString();

            return int.Parse(jsonVal);
        }

        public int GetWishlistIdFromUser(JObject jsonObject)
        {
            return GetJSONintValue(jsonObject, "wishlistId");
        }

        public int GetIdFromResponse(JObject jsonObject)
        {
            return GetJSONintValue(jsonObject, "id");
        }

        public JObject GetJsonObjectFromJarray(JArray jsonArray, int index)
        {
            return jsonArray[index].ToObject<JObject>();
        }


        public void AssertBookIsContainedInHouseholdWishlist(Book book, JArray wishlistArray, int position)
        {
            var bookOnWishlist = GetJsonObjectFromJarray(wishlistArray, position);
            string expectedTitle = book.Title;
            string expectedAuthor = book.Author;
            string expectedISBN = book.Isbn;
            string actualTitle = GetJSONstringValue(bookOnWishlist, "title");
            string actualAuthor = GetJSONstringValue(bookOnWishlist, "author");
            string actualISBN = GetJSONstringValue(bookOnWishlist, "isbn");

            Assert.Multiple(() =>
            {
                Assert.That(actualTitle, Is.EqualTo(expectedTitle));
                Assert.That(actualAuthor, Is.EqualTo(expectedAuthor));
                Assert.That(actualISBN, Is.EqualTo(expectedISBN));
            });
        }

        public bool AssertHoseholdWishlistHasCorrectSize(JArray wishlistArray)
        {
            Console.WriteLine(wishlistArray.Count);
            if (wishlistArray.Count == 0 || wishlistArray.Count < 3 || wishlistArray.Count > 3)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }
    }
}
