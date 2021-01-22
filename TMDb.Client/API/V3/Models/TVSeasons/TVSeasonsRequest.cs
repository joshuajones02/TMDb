using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public abstract class TVSeasonsRequest : TMDbRequest
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

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Refactor, some endpoints don't accept language (i.e. DeleteTVEpisodeRating)")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}