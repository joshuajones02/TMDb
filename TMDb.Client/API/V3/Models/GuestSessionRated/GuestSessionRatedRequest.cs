using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.GuestSessionRated
{
    public enum GuestSessionRatingSortyBy
    {
        CreatedDescending,
        CreatedAscending
    }

    public class GuestSessionRatedRequest : TMDbRequest
    {
        [JsonIgnore]
        [ApiParameter(
            Name = "guest_session_id")]
        public string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "language")]
        public string Language { get; set; }

        [ApiParameter(
            Name = "sort_by")]
        public GuestSessionRatingSortyBy SortBy { get; set; }
    }
}