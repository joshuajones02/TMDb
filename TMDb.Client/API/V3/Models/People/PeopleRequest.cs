using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.People
{
    public abstract class PeopleRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "person_id",
            ParameterType = ParameterType.Path)]
        public virtual int PersonId { get; set; }
    }
}