using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Genres
{
    public class GenresRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string Language { get; set; }
    }
}