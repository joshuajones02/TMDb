using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Movies
{
    /// <summary>
    /// Get the images that belong to a movie.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/images")]
    public class MovieImagesRequest : MovieBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        // TODO: Add null or 2 char count validation")]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Querying images with a language parameter will filter the results. If you want to include a
        /// fallback language (especially useful for backdrops) you can use the include_image_language
        /// parameter.This should be a comma seperated value like so: include_image_language= en,null.
        /// </summary>
        [ApiParameter(
            Name = "include_image_language",
            ParameterType = ParameterType.Query)]
        // TODO: Add null or 2 char count validation")]
        public virtual string ImageLanguage { get; set; }
    }
}