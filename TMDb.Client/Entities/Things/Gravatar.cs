using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDb.Client.Entities.Things
{
    public class Gravatar
    {
        [JsonProperty("hash")]
        public virtual string Hash { get; set; }
    }
}