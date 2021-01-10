using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class MovieDetailsRequest : TMDbRequest
    {
        /// <summary>
        /// Append requests within the same namespace to the response.
        ///     Example: https://api.themoviedb.org/3/movie/157336?api_key={api_key}&append_to_response=videos,images
        ///     Pattern: [\w]+
        /// </summary>
        [JsonProperty("append_to_response")]
        public string AppendToResponse { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}