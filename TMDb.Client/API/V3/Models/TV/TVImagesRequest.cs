using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    /// <summary>
    /// Get the images that belong to a TV show.
    /// Querying images with a language parameter will filter the results.
    /// If you want to include a fallback language (especially useful for
    /// backdrops) you can use the include_image_language parameter. This
    /// should be a comma seperated value like so:
    /// include_image_language= en,null.
    /// </summary>
    public class TVImagesRequest : TVBaseRequest
    {
        /// <summary>
        /// Pass a ISO 639-1 value to display translated data for the fields that support it.
        ///     minLength: 2
        ///     pattern: ([a - z]{2})-([A - Z]{2})
        ///     default: en - US
        /// </summary>
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}