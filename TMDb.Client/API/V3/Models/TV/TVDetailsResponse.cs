using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;
using TMDb.Client.Entities.Organizations;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVDetailsResponse : TMDbResponse, ITV
    {
        [JsonProperty("in_production")]
        public virtual bool? InProduction { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_count")]
        public virtual int? VoteCount { get; set; }

        [JsonProperty("number_of_episodes")]
        public virtual int? NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons")]
        public virtual int? NumberOfSeasons { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_language")]
        public virtual string OriginalLanguage { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("status")]
        public virtual string Status { get; set; }

        [JsonProperty("tagline")]
        public virtual string Tagline { get; set; }

        [JsonProperty("type")]
        public virtual string Type { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("first_air_date")]
        public virtual DateTime? FirstAirDate { get; set; }

        [JsonProperty("last_air_date")]
        public virtual DateTime? LastAirDate { get; set; }

        [JsonProperty("next_episode_to_air")]
        public virtual Episode NextEpisodeToAir { get; set; }

        [JsonProperty("last_episode_to_air")]
        public virtual Episode LastEpisodeToAir { get; set; }

        [JsonProperty("homepage")]
        public virtual Uri Homepage { get; set; }

        [JsonProperty("episode_run_time")]
        public virtual IEnumerable<int> EpisodeRunTime { get; set; }

        [JsonProperty("languages")]
        public virtual IEnumerable<string> Languages { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> OriginCountry { get; set; }

        [JsonProperty("created_by")]
        // TODO: Refactor this an entity?")]
        public virtual IEnumerable<TVDetailsCreatedBy> CreatedBy { get; set; }

        [JsonIgnore]
        // TODO: Create JSON Converter that will use Genres to fill data")]
        public virtual IEnumerable<int> GenreIds { get; set; }

        [JsonProperty("genres")]
        public virtual IEnumerable<TVGenre> Genres { get; set; }

        [JsonProperty("networks")]
        public virtual IEnumerable<Network> Networks { get; set; }

        [JsonProperty("production_companies")]
        public virtual IEnumerable<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public virtual IEnumerable<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("seasons")]
        public virtual IEnumerable<Season> Seasons { get; set; }

        [JsonProperty("spoken_languages")]
        public virtual IEnumerable<Language> SpokenLanguages { get; set; }
    }

    //public partial class LastEpisodeToAir
    //{
    //    [JsonProperty("air_date")]
    //    public DateTime? AirDate { get; set; }

    //    [JsonProperty("episode_number")]
    //    public int EpisodeNumber { get; set; }

    //    [JsonProperty("id")]
    //    public int Id { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("overview")]
    //    public string Overview { get; set; }

    //    [JsonProperty("production_code")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public int ProductionCode { get; set; }

    //    [JsonProperty("season_number")]
    //    public int SeasonNumber { get; set; }

    //    [JsonProperty("still_path")]
    //    public string StillPath { get; set; }

    //    [JsonProperty("vote_average")]
    //    public double VoteAverage { get; set; }

    //    [JsonProperty("vote_count")]
    //    public int VoteCount { get; set; }
    //}

    //public class Season
    //{
    //    [JsonProperty("air_date")]
    //    public DateTime? AirDate { get; set; }

    //    [JsonProperty("episode_count")]
    //    public int EpisodeCount { get; set; }

    //    [JsonProperty("id")]
    //    public int Id { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("overview")]
    //    public string Overview { get; set; }

    //    [JsonProperty("poster_path")]
    //    public string PosterPath { get; set; }

    //    [JsonProperty("season_number")]
    //    public int SeasonNumber { get; set; }
    //}
}