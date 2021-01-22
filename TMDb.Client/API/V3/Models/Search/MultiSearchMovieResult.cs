using TMDb.Client.Entities.Media;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Search
{
    public class MultiSearchMovieResult : MovieMinified
    {
        public MediaType MediaType { get; set; }
    }
}