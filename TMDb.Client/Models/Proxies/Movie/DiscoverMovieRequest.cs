using TMDb.Client.Enums;
using TMDb.Client.JsonConverters;
using Newtonsoft.Json;
using System;

namespace TMDb.Client.Models
{
    public class DiscoverMovieRequest : TMDbRequest
    {
        public DiscoverMovieRequest() : this(null)
        {
        }

        public DiscoverMovieRequest(int? page)
        {
            Page = page ?? 1;
        }

        [JsonProperty("include_adult")]
        public bool? IncludeAdult { get; set; }

        [JsonProperty("include_video")]
        public bool? IncludeVideo { get; set; }

        [JsonProperty("page")]
        [JsonRequired]
        public int Page { get; set; }

        [JsonProperty("primary_release_year")]
        public int? PrimaryReleaseYear { get; set; }

        [JsonProperty("with_release_type")]
        public int? WithReleaseType { get; set; }
        
        [JsonProperty("with_runtime.gte")]
        public int? WithRuntimeGte { get; set; }
        
        [JsonProperty("with_runtime.lte")]
        public int? WithRuntimeLte { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("vote_count.gte")]
        public int? VoteCountGte { get; set; }

        [JsonProperty("vote_count.lte")]
        public int? VoteCountLte { get; set; }

        [JsonProperty("vote_average.gte")]
        public int? VoteAverageGte { get; set; }

        [JsonProperty("vote_average.lte")]
        public int? VoteAverageLte { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("with_original_language")]
        public string WithOriginalLanguage { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("certification_country")]
        public string CertificationCountry { get; set; }

        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("certification.lte")]
        public string CertificationLte { get; set; }

        [JsonProperty("certification.gte")]
        public string CertificationGte { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_cast")]
        public string WithCast { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_crew")]
        public string WithCrew { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_people")]
        public string WithPeople { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_companies")]
        public string WithCompanies { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_genres")]
        public string Genres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("without_genres")]
        public string GenreExclusions { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_keywords")]
        public string WithKeywords { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("without_keywords")]
        public string WithoutKeywords { get; set; }

        [JsonProperty("primary_release_date.gte")]
        public DateTime? PrimaryReleaseDateGte { get; set; }

        [JsonProperty("primary_release_date.lte")]
        public DateTime? PrimaryReleaseDateLte { get; set; }

        [JsonProperty("release_date.gte")]
        public DateTime? ReleaseDateGte { get; set; }

        [JsonProperty("release_date.lte")]
        public DateTime? ReleaseDateLte { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [JsonProperty("sort_by")]
        public DiscoverMovieSortBy SortBy { get; set; }
    }
}