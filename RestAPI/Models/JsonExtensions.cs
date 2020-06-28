using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace RestAPI.Models
{
    public static class JsonExtensions
    {
        public static string ToJson(this User self) => JsonConvert.SerializeObject(self, Converter.Settings);

        public static string ToJson(this Book self) => JsonConvert.SerializeObject(self, Converter.Settings);

        public static string ToJson(this Household self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
