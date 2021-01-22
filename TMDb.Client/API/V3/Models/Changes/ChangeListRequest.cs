using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Changes
{
    public abstract class ChangeListRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Handle default of (1)")]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "start_date",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? StartDate { get; set; }

        [ApiParameter(
            Name = "end_date",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? EndDate { get; set; }
    }
}