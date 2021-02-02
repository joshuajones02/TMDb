using System;
using System.IO;
using System.Threading.Tasks;

namespace TMDb.Client.Api.V3.ClientProxies
{
    // TODO: Need a way to alter base address inside http client proxy (subdomain is different)")]
    public class ExportsProxy : ApiProxy
    {
        public ExportsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Uri ExportUri(string exportType)
        {
            var formattedDate = DateTime.UtcNow.ToString("MM_dd_yyyy");

            return new UriBuilder("http://files.tmdb.org")
            {
                Path = $"/p/exports/{exportType}_ids_{formattedDate}.json.gz"
            }.Uri;
        }

        public virtual Task GetLatestCollectionAsync() => DownloadExportAsync("collection");
        public virtual Task GetLatestKeywordsAsync() => DownloadExportAsync("keyword");
        public virtual Task GetLatestMovieAsync() => DownloadExportAsync("movie");
        public virtual Task GetLatestPeopleAsync() => DownloadExportAsync("person");
        public virtual Task GetLatestProductionCompaniesAsync() => DownloadExportAsync("production_company");
        public virtual Task GetLatestTVNetworksAsync() => DownloadExportAsync("tv_network");
        public virtual Task GetLatestTVSeriesAsync() => DownloadExportAsync("tv_series");

        protected async virtual Task DownloadExportAsync(string exportType)
        {
            var exportUri = ExportUri(exportType);
            var fileName = exportUri.AbsolutePath.Replace("/p/exports/", "");

            if (File.Exists(fileName))
                throw new Exception($"{fileName} has already been downloaded");

            using var stream = await Client.Client.GetStreamAsync(exportUri);
            using var file = File.Create(fileName);
            await file.CopyToAsync(stream);
        }
    }
}