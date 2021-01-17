using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.People
{
    [ApiGetEndpoint("")]
    public class PopularPeopleRequest : PeopleRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}