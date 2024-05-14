
using Newtonsoft.Json.Linq;

namespace Core.Configurations
{
    public class ConfigurationProvider
    {       
        protected static T Load<T>(string filePath, string sectionName)=>JObject.Parse(File.ReadAllText(filePath)).SelectToken(sectionName).ToObject<T>();
       
    }
}
