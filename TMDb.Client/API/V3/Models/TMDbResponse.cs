using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models
{
    [Obsolete("TODO: Put the following property members into a child class, not all responses are collections")]
    public class TMDbResponse
    {
        [ApiParameter(
            Name = "page")]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "total_pages")]
        public virtual int TotalPages { get; set; }

        [ApiParameter(
            Name = "total_results")]
        public virtual int TotalResults { get; set; }
    }
}