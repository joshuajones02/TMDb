using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Reviews
{
    [ApiParameter(
        ParameterType = ParameterType.Path,
        Value = "/review/{review_id}")]
    public class ReviewsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "review_id",
            ParameterType = ParameterType.Path)]
        public virtual string ReviewId { get; set; }
    }
}