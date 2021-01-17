﻿using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVEpisodeDetailsRequest : TMDbRequest
    {
        /// <summary>
        /// Append requests within the same namespace to the response.
        ///     Example: https://api.themoviedb.org/3/movie/157336?api_key={api_key}&append_to_response=videos,images
        ///     Pattern: [\w]+
        /// </summary>
        [ApiParameter(
            Name = "append_to_response",
            ParameterType = ParameterType.Query)]
        public virtual string AppendToResponse { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}