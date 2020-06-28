

using Newtonsoft.Json;

namespace RestAPI.Models
{
    public class Book
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Include)]
        public string Author { get; set; }

        [JsonProperty("isbn", NullValueHandling = NullValueHandling.Include)]
        public string Isbn { get; set; }

        [JsonProperty("publicationDate", NullValueHandling = NullValueHandling.Include)]
        public string PublicationDate { get; set; }
    }
}
