using TMDb.Client.Entities.Media;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.People
{
    public class PersonKnownForMovie : MovieMinified
    {
        public MediaType MediaType { get; set; }
    }
}