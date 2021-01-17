using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Enums;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.Credits
{
    public class CreditsResponse : TMDbResponse
    {
        [ApiParameter(
            Name = "id")]
        public virtual string Id { get; set; }

        [ApiParameter(
            Name = "credit_type")]
        public virtual string CreditType { get; set; }

        [ApiParameter(
            Name = "department")]
        public virtual string Department { get; set; }

        [ApiParameter(
            Name = "job")]
        public virtual string Job { get; set; }

        [ApiParameter(
            Name = "media_type")]
        public virtual MediaType MediaType { get; set; }

        [ApiParameter(
            Name = "media")]
        public virtual Media Media { get; set; }

        [ApiParameter(
            Name = "person")]
        public virtual Person Person { get; set; }
    }

    public class Media
    {
        [ApiParameter(
            Name = "id")]
        public virtual int Id { get; set; }

        [ApiParameter(
            Name = "name")]
        public virtual string Name { get; set; }

        [ApiParameter(
            Name = "original_name")]
        public virtual string OriginalName { get; set; }

        [ApiParameter(
            Name = "character")]
        public virtual string Character { get; set; }

        [ApiParameter(
            Name = "episodes")]
        public virtual IEnumerable<Episode> Episodes { get; set; }

        [ApiParameter(
            Name = "seasons")]
        public virtual IEnumerable<Season> Seasons { get; set; }
    }
}