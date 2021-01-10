using TMDb.Client.Enums;
using TMDb.Client.JsonConverters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TMDb.Client.Models
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

        [JsonProperty("include_null_first_air_dates")]
        public bool? IncludeNullFirstAirDates { get; set; }

        [JsonProperty("screened_theatrically")]
        public bool? IsScreenedTheatrically { get; set; }

        [JsonProperty("page")]
        [JsonRequired]
        public int Page { get; set; }

        [JsonProperty("with_runtime.gte")]
        public int? WithRuntimeGte { get; set; }

        [JsonProperty("with_runtime.lte")]
        public int? WithRuntimeLte { get; set; }

        [JsonProperty("vote_count.gte")]
        public int? VoteCountGte { get; set; }

        [JsonProperty("vote_average.gte")]
        public int? VoteAverageGte { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("with_original_language")]
        public string WithOriginalLanguage { get; set; }

        [JsonProperty("air_date.gte")]
        public string AirDateGte { get; set; }

        [JsonProperty("air_date.lte")]
        public string AirDateLte { get; set; }

        [JsonProperty("first_air_date.gte")]
        public string FirstAirDateGte { get; set; }

        [JsonProperty("first_air_date.lte")]
        public string FirstAirDateLte { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_companies")]
        public string WithCompanies { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_genres")]
        public string Genres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("without_genres")]
        public string WithoutGenres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("with_keywords")]
        public string WithKeywords { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [JsonProperty("without_keywords")]
        public string WithoutKeywords { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; } = "America/New_York";

        [JsonProperty("with_networks")]
        public string WithNetworks { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [JsonProperty("sort_by")]
        public DiscoverTVSortBy SortBy { get; set; }
    }
}