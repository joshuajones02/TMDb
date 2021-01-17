using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiParameter(
        ParameterType = ParameterType.Endpoint,
        Value = "/list")]
    public class CreateListRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Query)]
        [ApiParameter(
            Name = "session_id")]
        [JsonRequired]
        [Required]
        public string SessionId { get; set; }

        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        [Required]
        public string ContentType { get; set; }

        [ApiParameter(
            Name = "name",
            ParameterType = ParameterType.JsonBody)]
        public string Name { get; set; }

        [ApiParameter(
            Name = "description",
            ParameterType = ParameterType.JsonBody)]
        public string Description { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.JsonBody)]
        public string LanguageAbbreviation { get; set; }
    }
}