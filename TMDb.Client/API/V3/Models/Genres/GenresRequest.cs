using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Genres
{
    public class GenresRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "language")]
        public string Language { get; set; }
    }
}