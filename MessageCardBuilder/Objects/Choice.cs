using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    public class Choice
    {
        public Choice(string display, string value)
        {
            Display = display;
            Value = value;
        }

        [JsonPropertyName("display")]
        public string Display { get; }

        [JsonPropertyName("value")]
        public string Value { get; }
    }
}
