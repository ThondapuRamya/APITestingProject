using APITestCaseCreation.Models;
using Newtonsoft.Json.Linq;


namespace APITestCaseCreation.Configurations
{
    public class ConfigurationProvider :Core.Configurations.ConfigurationProvider
    {
        protected const string FilePath = @"..\..\..\TestSettings.json";
        protected static readonly string SettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FilePath);

        public static APIDetails APICredentials => Load<APIDetails>(SettingsPath, "APIDetails");
    }
}
