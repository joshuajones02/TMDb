using Newtonsoft.Json;
using TMDb.Client.Attributes;

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
        [ApiParameter(
            Name = "external_id",
            ParameterType = ParameterType.Path)]
        public virtual string ExternalId { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "external_source",
            ParameterType = ParameterType.Query)]
        public virtual string ExternalSource { get; set; }
    }
}