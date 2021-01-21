using static TMDb.Client.Tests.Configuration;

namespace TMDb.Client.Tests
{
    public class TestsSettings
    {
        public string ApiKey { get; set; }
        public string Version { get; set; }

        public TestsSettings()
        {
            ApiKey = AppSettings.GetRequired("TestsSettings:ApiKey");
            Version = "3";
        }

        public static TestsSettings _instance;
        public static TestsSettings Instance => _instance = _instance ?? new TestsSettings();
    }
}