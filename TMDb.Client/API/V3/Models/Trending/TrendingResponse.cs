using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Trending
{
    public class TrendingResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<TrendingResult> Results { get; set; }
    }

    public class TrendingResult
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("adult", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Adult { get; set; }

        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Video { get; set; }

        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("original_title", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("original_name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string OriginalName { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Title { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        private string _title { set { Title = value; } }

        [JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime ReleaseDate { get; set; }

        [JsonProperty("first_air_date", NullValueHandling = NullValueHandling.Ignore)]
        private DateTime _releaseDate { set { ReleaseDate = value; } }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("original_language")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("media_type")]
        public virtual MediaType MediaType { get; set; }

        [JsonProperty("genre_ids")]
        public virtual IEnumerable<int> Genres { get; set; }

        //[JsonProperty("origin_country", NullValueHandling = NullValueHandling.Ignore)]
        //public virtual IEnumerable<OriginCountry> OriginCountry { get; set; }
    }
}