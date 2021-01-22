using TMDb.Client.Api.V3.Models.People;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Search
{
    public class MultiSearchPersonResult : PersonMinified
    {
        public MediaType MediaType { get; set; }
    }
}