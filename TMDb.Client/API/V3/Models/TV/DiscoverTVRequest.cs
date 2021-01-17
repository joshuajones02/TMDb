using Newtonsoft.Json;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.TV
{
    public class DiscoverTVRequest : TMDbRequest
    {
        public DiscoverTVRequest(int? page)
        {
            Page = page ?? 1;
        }

        [ApiParameter(
            Name = "include_null_first_air_dates")]
        public virtual bool? IncludeNullFirstAirDates { get; set; }

        [ApiParameter(
            Name = "screened_theatrically")]
        public virtual bool? IsScreenedTheatrically { get; set; }

        [ApiParameter(
            Name = "page")]
        [JsonRequired]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "with_runtime.gte")]
        public virtual int? WithRuntimeGte { get; set; }

        [ApiParameter(
            Name = "with_runtime.lte")]
        public virtual int? WithRuntimeLte { get; set; }

        [ApiParameter(
            Name = "vote_count.gte")]
        public virtual int? VoteCountGte { get; set; }

        [ApiParameter(
            Name = "vote_average.gte")]
        public virtual int? VoteAverageGte { get; set; }

        [ApiParameter(
            Name = "language")]
        public virtual string Language { get; set; }

        [ApiParameter(
            Name = "with_original_language")]
        public virtual string WithOriginalLanguage { get; set; }

        [ApiParameter(
            Name = "air_date.gte")]
        public virtual string AirDateGte { get; set; }

        [ApiParameter(
            Name = "air_date.lte")]
        public virtual string AirDateLte { get; set; }

        [ApiParameter(
            Name = "first_air_date.gte")]
        public virtual string FirstAirDateGte { get; set; }

        [ApiParameter(
            Name = "first_air_date.lte")]
        public virtual string FirstAirDateLte { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_companies")]
        public virtual string WithCompanies { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_genres")]
        public virtual string Genres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_genres")]
        public virtual string WithoutGenres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_keywords")]
        public virtual string WithKeywords { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_keywords")]
        public virtual string WithoutKeywords { get; set; }

        [ApiParameter(
            Name = "timezone")]
        public virtual string Timezone { get; set; } = "America/New_York";

        [ApiParameter(
            Name = "with_networks")]
        public virtual string WithNetworks { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [ApiParameter(
            Name = "sort_by")]
        public virtual DiscoverTVSortBy SortBy { get; set; }
    }
}