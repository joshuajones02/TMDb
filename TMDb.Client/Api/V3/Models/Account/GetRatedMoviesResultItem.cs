using Newtonsoft.Json;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Api.V3.Models.Account
{
    public class GetRatedMoviesResultItem : MovieMinified
    {
        [JsonProperty("rating")]
        public virtual double? Rating { get; set; }
    }
}