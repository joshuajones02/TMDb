using static TMDb.Client.Tests.Configuration;

namespace TMDb.Client.Tests
{
    public class TestsSettings
    {
        public string ApiKey { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Version { get; set; }

        public TestsSettings()
        {
            ApiKey = AppSettings.GetRequired("TestsSettings:ApiKey");
            Password = AppSettings.GetRequired("TestsSettings:Password");
            Username = AppSettings.GetRequired("TestsSettings:Username");
            Version = "3";
        }

        private static TestsSettings _instance;
        public static TestsSettings Instance => _instance ??= new TestsSettings();
    }
}