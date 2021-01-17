using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiPostEndpoint("/list")]
    public class CreateListRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [JsonRequired]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        [Required]
        public virtual string ContentType { get; set; }

        [ApiParameter(
            Name = "name",
            ParameterType = ParameterType.JsonBody)]
        public virtual string Name { get; set; }

        [ApiParameter(
            Name = "description",
            ParameterType = ParameterType.JsonBody)]
        public virtual string Description { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.JsonBody)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}