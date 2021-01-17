using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.People
{
    [ApiGetEndpoint("")]
    public class PeopleTVCreditsRequest : PeopleRequest
    {
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}