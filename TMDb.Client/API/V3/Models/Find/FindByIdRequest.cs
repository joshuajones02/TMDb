using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Find
{
    /// <summary>
    ///     	        Movies	TVShows TVSeasons TVEpisodes People
    ///     IMDb ID     	✓	     ✓	       ✗	      ✓      ✓
    ///     TVDB ID	        ✗	     ✓	       ✓	      ✓      ✗
    ///     Freebase MID*	✗	     ✓	       ✓	      ✓      ✓
    ///     Freebase ID*	✗	     ✓	       ✓	      ✓      ✓
    ///     TVRage ID*	    ✗	     ✓	       ✓	      ✓      ✓
    ///
    ///     *Defunct or no longer available as a service.
    /// </summary>
    public class FindByIdRequest : TMDbRequest
    {
        [JsonIgnore]
        [ApiParameter(
            Name = "external_id")]
        public string ExternalId { get; set; }

        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "external_source")]
        public string ExternalSource { get; set; }
    }
}