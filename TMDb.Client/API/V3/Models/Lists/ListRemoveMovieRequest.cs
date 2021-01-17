using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiPostEndpoint("/list/{list_id}/add_item")]
    public class ListRemoveMovieRequest : ListRequestBase
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        [Required]
        public virtual string ContentType { get; set; }

        [ApiParameter(
            Name = "media_id",
            ParameterType = ParameterType.JsonBody)]
        [Obsolete("// TODO: Validation needed, value must be 1 or more")]
        public virtual int MediaId { get; set; }
    }
}