using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVCreatedBy
    {
        [ApiParameter(
            Name = "id",
            ParameterType = ParameterType.Query)]
        public virtual int Id { get; set; }

        [ApiParameter(
            Name = "credit_id",
            ParameterType = ParameterType.Query)]
        public virtual string CreditId { get; set; }

        [ApiParameter(
            Name = "name",
            ParameterType = ParameterType.Query)]
        public virtual string Name { get; set; }

        [ApiParameter(
            Name = "gender",
            ParameterType = ParameterType.Query)]
        public virtual int Gender { get; set; }

        [ApiParameter(
            Name = "profile_path",
            ParameterType = ParameterType.Query)]
        public virtual string ProfilePath { get; set; }
    }
}