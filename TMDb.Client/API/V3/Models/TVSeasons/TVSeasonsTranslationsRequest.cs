﻿using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/translations")]
    public class TVSeasonsTranslationsRequest : TVSeasonsRequest
    {
    }
}