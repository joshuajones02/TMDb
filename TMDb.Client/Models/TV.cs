using TMDb.Client.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class TV
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("in_production")]
        public virtual bool InProduction { get; set; }

        [JsonProperty("next_episode_to_air")]
        public virtual Episode NextEpisodeToAir { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("number_of_episodes")]
        public virtual int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons")]
        public virtual int NumberOfSeasons { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

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
        public virtual DateTime FirstAirDate { get; set; }

        [JsonProperty("last_air_date")]
        public virtual DateTime LastAirDate { get; set; }

        [JsonProperty("last_episode_to_air")]
        public virtual Episode LastEpisodeToAir { get; set; }

        [JsonProperty("homepage")]
        public virtual Uri Homepage { get; set; }

        [JsonProperty("created_by")]
        public virtual IEnumerable<CreatedBy> CreatedBy { get; set; }

        [JsonProperty("episode_run_time")]
        public virtual IEnumerable<int> EpisodeRunTime { get; set; }

        [JsonProperty("genres")]
        public virtual IEnumerable<MovieGenre> Genres { get; set; }

        [JsonProperty("languages")]
        public virtual IEnumerable<string> Languages { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> OriginCountry { get; set; }

        [JsonProperty("networks")]
        public virtual IEnumerable<Network> Networks { get; set; }

        [JsonProperty("production_companies")]
        public virtual IEnumerable<Network> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public virtual IEnumerable<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("seasons")]
        public virtual IEnumerable<Season> Seasons { get; set; }

        [JsonProperty("spoken_languages")]
        public virtual IEnumerable<SpokenLanguage> SpokenLanguages { get; set; }
    }
}
