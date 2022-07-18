using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Facts are a very important component of a section. They often contain the information that really matters to the user.
    /// </summary>
    public class Fact
    {
        public Fact(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// The name of the fact. Do keep fact names short. Avoid using Markdown formatting.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The value of the fact. 
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; }
    }
}