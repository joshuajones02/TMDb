using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Lists
{
    [ApiGetEndpoint("/list/{list_id}/item_status")]
    public class ListItemStatusRequest : ListRequestBase
    {
        [ApiParameter(
            Name = "movie_id",
            ParameterType = ParameterType.Query)]
        public virtual int MovieId { get; set; }
    }
}