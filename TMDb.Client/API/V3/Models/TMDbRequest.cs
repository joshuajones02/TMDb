using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Settings;

namespace TMDb.Client.API.V3.Models
{
    [Obsolete("on startup write check to make sure all members/propertyinfo have ApiParameter attribute")]
    public abstract class TMDbRequest : RequestBase
    {
        [Obsolete("// TODO: *** Refactor out this reference directly to settings, apply it in another layer.")]
        public TMDbRequest() : this(DefaultTMDbSettings.Instance)
        {
        }

        [Obsolete("// TODO: *** Refactor out this reference directly to settings, apply it in another layer.")]
        public TMDbRequest(ITMDbSettings settings)
        {
            // TODO: *** Refactor out this reference directly to settings, apply it in another layer.
            ApiKey = settings.ApiKey;

            // TODO: *** Refactor out this reference directly to settings, apply it in another layer.
            Version = settings.Version;
        }

        [ApiParameter(
            Name = "api_key",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string ApiKey { get; set; }

        [ApiParameter(
            Name = "version",
            ParameterType = ParameterType.PathPrepend)]
        [Required]
        public virtual string Version { get; set; }
    }
}