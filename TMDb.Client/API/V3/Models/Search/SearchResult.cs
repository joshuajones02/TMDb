using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchResult
    {
        [ApiParameter(
            Name = "id")]
        public virtual int Id { get; set; }

        [ApiParameter(
            Name = "popularity")]
        public virtual double Popularity { get; set; }
    }
}