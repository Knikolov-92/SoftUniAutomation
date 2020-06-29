using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace RestAPI.Utils
{
    public class GeneralMethods
    {
        public GeneralMethods()
        { }

        public string GetJSONstringValue(JObject jsonObject, string jsonKey)
        {
            return jsonObject.GetValue(jsonKey).ToString();
        }

        public int GetJSONintValue(JObject jsonObject, string jsonKey)
        {
            var jsonVal = jsonObject.GetValue(jsonKey).ToString();

            return int.Parse(jsonVal);
        }

        public int GetWishlistIdFromUser(JObject jsonObject)
        {
            return GetJSONintValue(jsonObject, "wishlistId");
        }

        public int GetIdFromResponse(JObject jsonObject)
        {
            return GetJSONintValue(jsonObject, "id");
        }

        public JObject GetJsonObjectFromJarray(JArray jsonArray, int index)
        {
            return jsonArray[index].ToObject<JObject>();
        }
    }
}
