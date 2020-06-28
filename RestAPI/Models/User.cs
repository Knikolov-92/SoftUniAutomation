

using Newtonsoft.Json;

namespace RestAPI.Models
{
    public class User
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("householdId", NullValueHandling = NullValueHandling.Include)]
        public int HouseholdID { get; set; }
        
        [JsonProperty("wishlistId", NullValueHandling = NullValueHandling.Ignore)]
        public int WishlistID { get; set; }
    }
}
