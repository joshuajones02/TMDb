using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesExternalIdsResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int TMDbId { get; set; }

        /// <summary>
        /// TVDB ID
        /// </summary>
        [JsonProperty("tvdb_id")]
        public virtual int TvdbId { get; set; }

        /// <summary>
        /// TVRage ID
        ///     *Defunct or no longer available as a service.
        /// </summary>
        [JsonProperty("tvrage_id")]
        public virtual int TVRageId { get; set; }

        /// <summary>
        /// Freebase MID
        ///     *Defunct or no longer available as a service.
        /// </summary>
        [JsonProperty("freebase_mid")]
        public virtual string FreebaseMid { get; set; }

        /// <summary>
        /// Freebase ID
        ///     *Defunct or no longer available as a service.
        /// </summary>
        [JsonProperty("freebase_id")]
        public virtual string FreebaseId { get; set; }
    }
}