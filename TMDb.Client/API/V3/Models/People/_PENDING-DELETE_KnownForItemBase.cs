//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using TMDb.Client.Enums;

//namespace TMDb.Client.Api.V3.Models.People
//{
//    public class MovieMinified : KnownForItemBase
//    {
//        [JsonProperty("adult")]
//        public bool? Adult { get; set; }

//        [JsonProperty("video")]
//        public bool? Video { get; set; }

//        [JsonProperty("original_title")]
//        public string OriginalTitle { get; set; }

//        [JsonProperty("title")]
//        public string Title { get; set; }

//        [JsonProperty("release_date")]
//        public DateTime? ReleaseDate { get; set; }
//    }

//    public class TVMinified : KnownForItemBase
//    {
//        [JsonProperty("name")]
//        public string Name { get; set; }

//        [JsonProperty("original_name")]
//        public string OriginalName { get; set; }

//        [JsonProperty("first_air_date")]
//        public DateTime? FirstAirDate { get; set; }

//        [JsonProperty("origin_country")]
//        public IEnumerable<string> OriginCountry { get; set; }
//    }

//    public abstract class KnownForItemBase
//    {
//        [JsonProperty("popularity")]
//        public double? Popularity { get; set; }

//        [JsonProperty("vote_average")]
//        public double? VoteAverage { get; set; }

//        [JsonProperty("id")]
//        public int Id { get; set; }

//        [JsonProperty("vote_count")]
//        public int VoteCount { get; set; }

//        [JsonProperty("backdrop_path")]
//        public string BackdropPath { get; set; }

//        [JsonProperty("original_language")]
//        public string LanguageAbbreviation { get; set; }

//        [JsonProperty("overview")]
//        public string Overview { get; set; }

//        [JsonProperty("poster_path")]
//        public string PosterPath { get; set; }

//        [JsonProperty("media_type")]
//        public MediaType MediaType { get; set; }

//        [JsonProperty("genre_ids")]
//        public IEnumerable<int> GenreIds { get; set; }
//    }
//}