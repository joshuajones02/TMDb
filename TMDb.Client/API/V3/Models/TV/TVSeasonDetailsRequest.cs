using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVSeasonDetailsRequest : TVSeasonsRequest
    {
        /// <summary>
        /// Append requests within the same namespace to the response.
        ///     Example: https://api.themoviedb.org/3/movie/157336?api_key={api_key}&append_to_response=videos,images
        ///     Pattern: [\w]+
        /// </summary>
        [ApiParameter(
            Name = "append_to_response")]
        public string AppendToResponse { get; set; }
    }
}