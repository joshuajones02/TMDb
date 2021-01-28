using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Lists
{
    [ApiPostEndpoint("/list/{list_id}/remove_item")]
    public class ListRemoveMovieRequest : ListRequestBase
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        //[ApiParameter(
        //    Name = "Content-Type",
        //    ParameterType = ParameterType.Header)]
        //public virtual string ContentType => Constants.ContentType.Json;

        [ApiParameter(
            Name = "media_id",
            ParameterType = ParameterType.JsonBody)]
        // TODO: Validation needed, value must be 1 or more
        public virtual int MediaId { get; set; }
    }
}