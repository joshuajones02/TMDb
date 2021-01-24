using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.People
{
    public abstract class PeopleBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "person_id",
            ParameterType = ParameterType.Path)]
        public virtual int PersonId { get; set; }
    }
}