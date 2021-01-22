using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TV
{
    public abstract class TVBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "tv_id",
            ParameterType = ParameterType.Path)]
        public virtual int TVId { get; set; }
    }
}