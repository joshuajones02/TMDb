using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.People
{
    [Obsolete("// TODO: Refactor with PersonMinified")]
    public class PeopleTVCreditsBasePerson
    {
        [JsonProperty("vote_average")]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("episode_count")]
        public virtual int EpisodeCount { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("original_language")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("first_air_date")]
        public virtual DateTime? FirstAirDate { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> OriginCountry { get; set; }

        [JsonProperty("genre_ids")]
        public virtual IEnumerable<int> GenreIds { get; set; }
    }
}