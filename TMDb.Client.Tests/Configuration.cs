using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace TMDb.Client.Tests
{
    public static class Configuration
    {
        public static IConfigurationRoot AppSettings { get; }
        public static string EnvironmentName { get; }

        static Configuration()
        {
            EnvironmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
            AppSettings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{EnvironmentName}.json", false, true)
                .Build();
        }
    }

    public static class IConfigurationRootExtensions
    {
        public static string Get(this IConfiguration config, string key) =>
            config.GetSection(key)?.Value;
    }
}