#if NEWTONSOFTJSON || DEBUG
using MessageCard.Builder.Converters.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageCard.Builder
{
    /// <summary>
    /// Options for Newtonsoft.Json serialization.
    /// </summary>
    public static class MessageCardJsonSerializerSettings
    {
        /// <summary>
        /// These options ensure the JSON output matches the specification for the Slack API.
        /// </summary>
        public static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings();

        static MessageCardJsonSerializerSettings()
        {
            Settings.NullValueHandling = NullValueHandling.Ignore;
            Settings.Converters.Add(new StringEnumConverter());
            Settings.Converters.Add(new RuntimeTypeJsonConverter());
        }
    }
}
#endif