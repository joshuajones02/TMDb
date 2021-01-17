using Newtonsoft.Json;
using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiParameter(ParameterType.Endpoint, "/list/{list_id}/item_status")]
    [Obsolete("// TODO: Move endpoints into configuration file")]
    public class ListItemStatusRequest : ListRequestBase
    {
        [ApiParameter(ParameterType.Query, "movie_id")]
        [ApiParameter(
            Name = "movie_id")]
        public int MovieId { get; set; }
    }
}