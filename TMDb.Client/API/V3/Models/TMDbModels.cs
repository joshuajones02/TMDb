using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models
{
    public partial class ProductionCompany
    {
        [ApiParameter(
            Name = "id")]
        public int Id { get; set; }

        [ApiParameter(
            Name = "logo_path")]
        public string LogoPath { get; set; }

        [ApiParameter(
            Name = "name")]
        public string Name { get; set; }

        [ApiParameter(
            Name = "origin_country")]
        public string OriginCountry { get; set; }
    }

    public partial class ProductionCountry
    {
        [ApiParameter(
            Name = "iso_3166_1")]
        public string Iso3166_1 { get; set; }

        [ApiParameter(
            Name = "name")]
        public string Name { get; set; }
    }

    public partial class SpokenLanguage
    {
        [ApiParameter(
            Name = "english_name")]
        public string EnglishName { get; set; }

        [ApiParameter(
            Name = "iso_639_1")]
        public string Iso639_1 { get; set; }

        [ApiParameter(
            Name = "name")]
        public string Name { get; set; }
    }
}