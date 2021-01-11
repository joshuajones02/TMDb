using TMDb.Client.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;

namespace TMDb.Client.Models
{
    public class TrendingResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<TrendingResult> Results { get; set; }
    }

    public partial class TrendingResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("adult", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Adult { get; set; }

        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Video { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("original_title", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("original_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalName { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        private string _title { set { Title = value; } }

        [JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("first_air_date", NullValueHandling = NullValueHandling.Ignore)]
        private DateTime _releaseDate { set { ReleaseDate = value; } }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("original_language")]
        public string LanguageAbbreviation { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("media_type")]
        public MediaType MediaType { get; set; }

        [JsonProperty("genre_ids")]
        public IEnumerable<TMDbGenre> Genres { get; set; }

        //[JsonProperty("origin_country", NullValueHandling = NullValueHandling.Ignore)]
        //public IEnumerable<OriginCountry> OriginCountry { get; set; }
    }
}