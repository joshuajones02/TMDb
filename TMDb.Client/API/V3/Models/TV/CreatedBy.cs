using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TV
{
    public partial class CreatedBy
    {
        [ApiParameter(
            Name = "id")]
        public int Id { get; set; }

        [ApiParameter(
            Name = "credit_id")]
        public string CreditId { get; set; }

        [ApiParameter(
            Name = "name")]
        public string Name { get; set; }

        [ApiParameter(
            Name = "gender")]
        public int Gender { get; set; }

        [ApiParameter(
            Name = "profile_path")]
        public string ProfilePath { get; set; }
    }
}