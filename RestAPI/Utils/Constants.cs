

namespace RestAPI.Utils
{
    public class Constants
    {
        public const string API_BASE_URL = "http://localhost:3000/";
        public const string G_TOKEN_NAME = "G-Token";
        public const string G_TOKEN_VALUE = "ROM831ESV";
        public const string AUTHORIZATION_NAME = "admin";
        public const string AUTHORIZATION_PASSWORD = "admin";
        public const string BOOKS_ENDPOINT = "books";
        public const string HOUSEHOLDS_ENDPOINT = "households";
        public const string USERS_ENDPOINT = "users";
        public const string WISHLISTS_ENDPOINT = "wishlists";
        public const string ADD_BOOK_TO_WISHLIST_ENDPOINT = "wishlists/{wishlistId}/books/{bookId}";
        public const string HOUSEHOLD_WISHLIST_ENDPOINT = "households/{householdId}/wishlistBooks";
    }
}
