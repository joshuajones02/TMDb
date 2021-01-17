using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiGetEndpoint("/list/{list_id}/item_status")]
    [Obsolete("// TODO: Move endpoints into configuration file")]
    public class ListItemStatusRequest : ListRequestBase
    {
        [ApiParameter(
            Name = "movie_id",
            ParameterType = ParameterType.Query)]
        public virtual int MovieId { get; set; }
    }
}