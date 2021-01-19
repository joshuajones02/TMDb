using TMDb.Client.Entities.Media;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Search
{
    public class MultiSearchMovieResult : MovieMinified
    {
        public MediaType MediaType { get; set; }
    }
}