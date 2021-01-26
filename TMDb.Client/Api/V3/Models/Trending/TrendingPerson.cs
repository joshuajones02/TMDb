using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Trending
{
    public class TrendingPerson
    {
        [JsonProperty("adult")]
        public bool? Adult { get; set; }

        [JsonProperty("popularity")]
        public double? Popularity { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("media_type")]
        public MediaType MediaType { get; set; }

        [JsonProperty("known_for")]
        public List<TrendingMovie> KnownFor { get; set; }
    }

    //public class TrendingResultItem
    //{
    //    public bool? Adult { get; set; }
    //    public string BackdropPath { get; set; }
    //    public List<int> GenreIds { get; set; }
    //    public int Id { get; set; }
    //    public string OriginalLanguage { get; set; }
    //    public string OriginalTitle { get; set; }
    //    public string Overview { get; set; }
    //    public string PosterPath { get; set; }
    //    public DateTime? ReleaseDate { get; set; }
    //    public string Title { get; set; }
    //    public bool? Video { get; set; }
    //    public double VoteAverage { get; set; }
    //    public int VoteCount { get; set; }
    //    public double Popularity { get; set; }
    //    public string MediaType { get; set; }
    //    public DateTime? FirstAirDate { get; set; }
    //    public string Name { get; set; }
    //    public List<string> OriginCountry { get; set; }
    //    public string OriginalName { get; set; }
    //}
}