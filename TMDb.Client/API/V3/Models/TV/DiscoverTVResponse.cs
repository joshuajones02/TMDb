using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TV
{
    public class DiscoverTVResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<TVResult> Results { get; set; }
    }

    public class TVResult
    {
        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("original_language")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("first_air_date")]
        public virtual DateTime? FirstAirDate { get; set; }

        /// <summary>
        /// Use ConfigurationProxy GetCountries to get full name
        /// </summary>
        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> CountryAbbreviation { get; set; }

        [JsonProperty("genre_ids")]
        public virtual IEnumerable<int> GenreIds { get; set; }
    }
}