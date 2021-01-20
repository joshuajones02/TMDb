using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Organizations;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Entities.Media
{
    public interface ITV : ITVMinified
    {
        bool? InProduction { get; set; }

        int? NumberOfEpisodes { get; set; }
        int? NumberOfSeasons { get; set; }

        string Status { get; set; }
        string Tagline { get; set; }
        string Type { get; set; }

        DateTime? LastAirDate { get; set; }

        Uri Homepage { get; set; }
        Episode LastEpisodeToAir { get; set; }
        Episode NextEpisodeToAir { get; set; }

        IEnumerable<int> EpisodeRunTime { get; set; }
        IEnumerable<string> Languages { get; set; }
        IEnumerable<string> OriginCountry { get; set; }
        [Obsolete("// TODO: Refactor this an entity?")]
        IEnumerable<API.V3.Models.TV.TVDetailsCreatedBy> CreatedBy { get; set; }
        IEnumerable<TVGenre> Genres { get; set; }
        IEnumerable<Language> SpokenLanguages { get; set; }
        IEnumerable<Network> Networks { get; set; }
        IEnumerable<ProductionCompany> ProductionCompanies { get; set; }
        IEnumerable<ProductionCountry> ProductionCountries { get; set; }
        IEnumerable<Season> Seasons { get; set; }
    }
}