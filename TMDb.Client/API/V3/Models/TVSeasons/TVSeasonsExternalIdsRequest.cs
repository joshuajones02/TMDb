using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/external_ids")]
    public class TVSeasonsExternalIdsRequest : TVSeasonsRequest
    {
    }
}