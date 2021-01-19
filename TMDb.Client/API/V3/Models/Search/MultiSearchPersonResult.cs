using TMDb.Client.API.V3.Models.People;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Search
{
    public class MultiSearchPersonResult : PersonMinified
    {
        public MediaType MediaType { get; set; }
    }
}