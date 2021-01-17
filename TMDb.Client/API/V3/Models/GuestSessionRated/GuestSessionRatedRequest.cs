using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.GuestSessionRated
{
    public enum GuestSessionRatingSortyBy
    {
        CreatedDescending,
        CreatedAscending
    }

    public class GuestSessionRatedRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Path)]
        public virtual string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string Language { get; set; }

        [ApiParameter(
            Name = "sort_by",
            ParameterType = ParameterType.Query)]
        public virtual GuestSessionRatingSortyBy SortBy { get; set; }
    }
}