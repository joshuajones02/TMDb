using TMDb.Client.Entities.Media;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PersonKnownForTV : TVMinified
    {
        public MediaType MediaType { get; set; }
    }
}