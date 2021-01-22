using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TV
{
    /// <summary>
    /// Get the images that belong to a TV show.
    /// Querying images with a language parameter will filter the results.
    /// If you want to include a fallback language (especially useful for
    /// backdrops) you can use the include_image_language parameter. This
    /// should be a comma seperated value like so:
    /// include_image_language= en,null.
    /// </summary>
    [ApiGetEndpoint("/tv/{tv_id}/images")]
    public class TVImagesRequest : TVBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}