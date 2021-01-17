using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Credits
{
    [ApiParameter(
        ParameterType = ParameterType.Endpoint,
        Value = "/credit/{credit_id}")]
    public class CreditsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "credit_id",
            ParameterType = ParameterType.Path)]
        public string CreditId { get; set; }
    }
}