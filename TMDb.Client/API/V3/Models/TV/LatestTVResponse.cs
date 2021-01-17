using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.TV
{
    public class LatestTVResponse
    {
        [JsonProperty("in_production")]
        public bool InProduction { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("number_of_episodes")]
        public int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons")]
        public int NumberOfSeasons { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("vote_average")]
        public int VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("poster_path")]
        public object PosterPath { get; set; }

        [JsonProperty("next_episode_to_air")]
        public object NextEpisodeToAir { get; set; }

        [JsonProperty("backdrop_path")]
        public object BackdropPath { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("original_language")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime FirstAirDate { get; set; }

        [JsonProperty("last_air_date")]
        public DateTime LastAirDate { get; set; }

        [JsonProperty("last_episode_to_air")]
        public Episode LastEpisodeToAir { get; set; }

        [JsonProperty("created_by")]
        public IEnumerable<CreatedBy> CreatedBy { get; set; }

        [JsonProperty("episode_run_time")]
        public IEnumerable<int> EpisodeRunTime { get; set; }

        [JsonProperty("genres")]
        public IEnumerable<MovieGenre> Genres { get; set; }

        [JsonProperty("languages")]
        public IEnumerable<string> LanguageAbbreviations { get; set; }

        [JsonProperty("networks")]
        public IEnumerable<Network> Networks { get; set; }

        [JsonProperty("production_companies")]
        public IEnumerable<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("origin_country")]
        public IEnumerable<string> CountryAbbreviations { get; set; }

        [JsonProperty("production_countries")]
        public IEnumerable<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("seasons")]
        public IEnumerable<Season> Seasons { get; set; }

        [JsonProperty("spoken_languages")]
        public IEnumerable<SpokenLanguage> SpokenLanguages { get; set; }
    }
}