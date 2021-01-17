using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Collections
{
    public class Translation
    {
        [ApiParameter(
            Name = "iso_639_1")]
        public virtual string Language { get; set; }

        [ApiParameter(
            Name = "iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [ApiParameter(
            Name = "name")]
        public virtual string Name { get; set; }

        [ApiParameter(
            Name = "english_name")]
        public virtual string EnglishName { get; set; }

        [ApiParameter(
            Name = "data")]
        public virtual TranslationData Data { get; set; }
    }

    public class TranslationData
    {
        [ApiParameter(
            Name = "title")]
        public virtual string Title { get; set; }

        [ApiParameter(
            Name = "overview")]
        public virtual string Overview { get; set; }

        [ApiParameter(
            Name = "homepage")]
        public virtual string Homepage { get; set; }
    }
}