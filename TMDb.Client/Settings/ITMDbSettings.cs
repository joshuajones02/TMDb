using System;

namespace TMDb.Client.Settings
{
    public interface ITMDbSettings
    {
        string ApiKey { get; }
        Uri BaseUrl { get; }
        TimeSpan Timeout { get; }
        string Version { get; }
    }
}