using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchResult
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }
    }
}