using Newtonsoft.Json;
using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Changes
{
    public class ChangeListRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "page")]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "start_date",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? StartDate { get; set; }

        [ApiParameter(
            Name = 
            propertyName: "end_date",
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonRequired]
        public virtual DateTime? EndDate { get; set; }
    }
}