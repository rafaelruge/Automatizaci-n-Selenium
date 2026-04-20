using System.IO;
using Newtonsoft.Json.Linq;

namespace Core.Utilities
{
    public class ConfigReader
    {
        public static string GetConfigValue(string key)
        {
            var json = File.ReadAllText("TestData/config.json");
            var data = JObject.Parse(json);
            return data[key].ToString();
        }
    }
}
