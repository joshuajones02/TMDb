using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Find
{
    public class FindByIdResponse : TMDbResponse
    {
        [JsonProperty("movie_results")]
        public virtual IEnumerable<FindByIdMovieResult> MovieResults { get; set; }

        [JsonProperty("person_results")]
        public virtual IEnumerable<FindByIdPersonResult> PersonResults { get; set; }

        [JsonProperty("tv_results")]
        public virtual IEnumerable<FindByIdTVResult> TvResults { get; set; }

        [JsonProperty("tv_episode_results")]
        public virtual IEnumerable<FindByIdTVEpisodeResult> TvEpisodeResults { get; set; }

        [JsonProperty("tv_season_results")]
        public virtual IEnumerable<FindByIdTVSeasonResult> TvSeasonResults { get; set; }
    }
}