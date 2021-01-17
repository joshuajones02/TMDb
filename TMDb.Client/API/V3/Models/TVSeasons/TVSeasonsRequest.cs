using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "tv_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int TvId { get; set; }

        [ApiParameter(
            Name = "season_number",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int SeasonNumber { get; set; }

        [ApiParameter(
            Name = "language", 
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Refactor, some endpoints don't accept language (i.e. DeleteTVEpisodeRating)")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}