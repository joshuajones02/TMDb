using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class LatestMovieRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }
    }
}