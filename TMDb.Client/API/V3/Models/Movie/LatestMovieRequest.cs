using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class LatestMovieRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}