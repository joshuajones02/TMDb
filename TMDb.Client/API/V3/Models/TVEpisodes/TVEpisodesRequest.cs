using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.API.V3.Models.TVSeasons;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public abstract class TVEpisodesRequest : TVSeasonsRequest
    {
        [ApiParameter(
            Name = "episode_number",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int EpisodeNumber { get; set; }
    }
}