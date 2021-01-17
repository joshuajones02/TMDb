﻿using Newtonsoft.Json;
using TMDb.Client.API.V3.Models.Changes;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesChangesRequest : ChangeListRequest
    {
        [ApiParameter(
            Name = "episode_id",
            ParameterType = ParameterType.Query)]
        [JsonRequired]
        public virtual int EpisodeId { get; set; }
    }
}