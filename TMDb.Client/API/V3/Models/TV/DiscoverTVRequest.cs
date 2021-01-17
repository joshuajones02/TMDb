using Newtonsoft.Json;
using TMDb.Client.Enums;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.TV
{
    public class DiscoverTVRequest : TMDbRequest
    {
        public DiscoverTVRequest() : this(null)
        {
        }

        public DiscoverTVRequest(int? page)
        {
            Page = page ?? 1;
        }

        [ApiParameter(
            Name = "include_null_first_air_dates")]
        public bool? IncludeNullFirstAirDates { get; set; }

        [ApiParameter(
            Name = "screened_theatrically")]
        public bool? IsScreenedTheatrically { get; set; }

        [ApiParameter(
            Name = "page")]
        [JsonRequired]
        public int Page { get; set; }

        [ApiParameter(
            Name = "with_runtime.gte")]
        public int? WithRuntimeGte { get; set; }

        [ApiParameter(
            Name = "with_runtime.lte")]
        public int? WithRuntimeLte { get; set; }

        [ApiParameter(
            Name = "vote_count.gte")]
        public int? VoteCountGte { get; set; }

        [ApiParameter(
            Name = "vote_average.gte")]
        public int? VoteAverageGte { get; set; }

        [ApiParameter(
            Name = "language")]
        public string Language { get; set; }

        [ApiParameter(
            Name = "with_original_language")]
        public string WithOriginalLanguage { get; set; }

        [ApiParameter(
            Name = "air_date.gte")]
        public string AirDateGte { get; set; }

        [ApiParameter(
            Name = "air_date.lte")]
        public string AirDateLte { get; set; }

        [ApiParameter(
            Name = "first_air_date.gte")]
        public string FirstAirDateGte { get; set; }

        [ApiParameter(
            Name = "first_air_date.lte")]
        public string FirstAirDateLte { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_companies")]
        public string WithCompanies { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_genres")]
        public string Genres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_genres")]
        public string WithoutGenres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_keywords")]
        public string WithKeywords { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_keywords")]
        public string WithoutKeywords { get; set; }

        [ApiParameter(
            Name = "timezone")]
        public string Timezone { get; set; } = "America/New_York";

        [ApiParameter(
            Name = "with_networks")]
        public string WithNetworks { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [ApiParameter(
            Name = "sort_by")]
        public DiscoverTVSortBy SortBy { get; set; }
    }
}