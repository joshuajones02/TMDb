using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchTVRequest : SearchRequest
    {
        [ApiParameter(
            Name = "include_adult",
            ParameterType = ParameterType.Query)]
        public virtual bool IncludeAdult { get; set; }

        [ApiParameter(
            Name = "first_air_date_year",
            ParameterType = ParameterType.Query)]
        public virtual int FirstAirDateYear { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}