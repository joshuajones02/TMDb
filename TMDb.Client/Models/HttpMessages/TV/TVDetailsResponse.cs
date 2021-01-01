using TMDb.Client.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class TVDetailsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("in_production")]
        public bool InProduction { get; set; }

        [JsonProperty("next_episode_to_air")]
        public object NextEpisodeToAir { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("number_of_episodes")]
        public int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons")]
        public int NumberOfSeasons { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime FirstAirDate { get; set; }

        [JsonProperty("last_air_date")]
        public DateTime LastAirDate { get; set; }

        [JsonProperty("last_episode_to_air")]
        public LastEpisodeToAir LastEpisodeToAir { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        [JsonProperty("created_by")]
        public IEnumerable<CreatedBy> CreatedBy { get; set; }

        [JsonProperty("episode_run_time")]
        public IEnumerable<int> EpisodeRunTime { get; set; }

        [JsonProperty("genres")]
        public IEnumerable<Genre> Genres { get; set; }

        [JsonProperty("languages")]
        public IEnumerable<string> Languages { get; set; }

        [JsonProperty("origin_country")]
        public IEnumerable<string> OriginCountry { get; set; }

        [JsonProperty("networks")]
        public IEnumerable<Network> Networks { get; set; }

        [JsonProperty("production_companies")]
        public IEnumerable<Network> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public IEnumerable<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("seasons")]
        public IEnumerable<Season> Seasons { get; set; }

        [JsonProperty("spoken_languages")]
        public IEnumerable<SpokenLanguage> SpokenLanguages { get; set; }
    }

    public partial class CreatedBy
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }
    }

    public partial class Network
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }

        [JsonProperty("origin_country")]
        public string OriginCountry { get; set; }
    }
}