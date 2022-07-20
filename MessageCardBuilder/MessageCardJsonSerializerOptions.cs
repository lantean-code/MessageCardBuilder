#if SYSTEMTEXTJSON || DEBUG
using MessageCard.Builder.Converters.SystemTextJson;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MessageCard.Builder
{
    /// <summary>
    /// Options for System.Text.Json serialization.
    /// </summary>
    public static class MessageCardJsonSerializerOptions
    {
        /// <summary>
        /// These options ensure the JSON output matches the specification for Legacy MessageCards.
        /// </summary>
        public static JsonSerializerOptions Options { get; } = new JsonSerializerOptions();

        static MessageCardJsonSerializerOptions()
        {
            Options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            Options.Converters.Add(new EnumMemberJsonConverter());
            Options.Converters.Add(new JsonStringEnumConverter());
            Options.Converters.Add(new RuntimeTypeJsonConverter());
        }
    }
}
#endif