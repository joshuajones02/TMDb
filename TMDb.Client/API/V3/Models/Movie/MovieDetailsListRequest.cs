using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class MovieDetailsListRequest : TMDbRequest
    {
        public MovieDetailsListRequest()
        {
        }

        public MovieDetailsListRequest(int page) =>
            Page = page;

        [ApiParameter(
            Name = 
            "page")]
        public int Page { get; set; }

        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }
    }
}