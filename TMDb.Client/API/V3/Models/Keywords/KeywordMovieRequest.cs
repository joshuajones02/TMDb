using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Keywords
{
    public class KeywordMovieRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "include_adult",
            ParameterType = ParameterType.Query)]
        public virtual bool IsAdult { get; set; }

        [ApiParameter(
            Name = "keyword_id",
            ParameterType = ParameterType.Path)]
        public virtual int KeywordId { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string Language { get; set; }
    }
}