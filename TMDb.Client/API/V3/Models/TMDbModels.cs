using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models
{
    public abstract class ProductionCompany
    {
        [ApiParameter(
            Name = "id",
            ParameterType = ParameterType.Query)]
        public virtual int Id { get; set; }

        [ApiParameter(
            Name = "logo_path",
            ParameterType = ParameterType.Query)]
        public virtual string LogoPath { get; set; }

        [ApiParameter(
            Name = "name",
            ParameterType = ParameterType.Query)]
        public virtual string Name { get; set; }

        [ApiParameter(
            Name = "origin_country",
            ParameterType = ParameterType.Query)]
        public virtual string OriginCountry { get; set; }
    }

    public class ProductionCountry
    {
        [ApiParameter(
            Name = "iso_3166_1",
            ParameterType = ParameterType.Query)]
        public virtual string Iso3166_1 { get; set; }

        [ApiParameter(
            Name = "name",
            ParameterType = ParameterType.Query)]
        public virtual string Name { get; set; }
    }

    public class SpokenLanguage
    {
        [ApiParameter(
            Name = "english_name",
            ParameterType = ParameterType.Query)]
        public virtual string EnglishName { get; set; }

        [ApiParameter(
            Name = "iso_639_1",
            ParameterType = ParameterType.Query)]
        public virtual string Iso639_1 { get; set; }

        [ApiParameter(
            Name = "name",
            ParameterType = ParameterType.Query)]
        public virtual string Name { get; set; }
    }
}