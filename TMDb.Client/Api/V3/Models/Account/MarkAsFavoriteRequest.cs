using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Account
{
    [ApiPostEndpoint("/account/{account_id}/favorite")]
    public class MarkAsFavoriteRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        public virtual string ContentType => Constants.ContentType.Json;

        [ApiParameter(
            Name = "account_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int? AccountId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }
    }
}