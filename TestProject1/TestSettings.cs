using Microsoft.Extensions.Configuration;

namespace TestProject1
{
    public static class TestSettings
    {
        static TestSettings()
        {
            SetDefaultValues();
        }

        public static IConfiguration TestConfiguration { get; } =
            new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        public static int Timeout { get; set; }

        public static void SetDefaultValues()
        {
            Timeout = TryParseIntValue(TestConfiguration["Settings:Common:Timeout"]);
        }

        private static int TryParseIntValue(string valueFromTestSettings)
        {
            int.TryParse(valueFromTestSettings, out var value);
            return value;
        }
    }
}