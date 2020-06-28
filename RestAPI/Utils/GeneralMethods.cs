using Newtonsoft.Json.Linq;


namespace RestAPI.Utils
{
    public class GeneralMethods
    {
        public GeneralMethods()
        { }

        public string GetJSONstringValue(JObject jObject, string jsonKey)
        {
            return jObject.GetValue(jsonKey).ToString();
        }

        public int GetJSONintValue(JObject jObject, string jsonKey)
        {
            var jsonVal = jObject.GetValue(jsonKey).ToString();

            return int.Parse(jsonVal);
        }
    }
}
