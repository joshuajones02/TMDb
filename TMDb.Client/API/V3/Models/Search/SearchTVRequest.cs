using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchTVRequest : SearchRequest
    {
        [ApiParameter(
            Name = "include_adult")]
        public bool IncludeAdult { get; set; }

        [ApiParameter(
            Name = "first_air_date_year")]
        public int FirstAirDateYear { get; set; }

        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }
    }
}