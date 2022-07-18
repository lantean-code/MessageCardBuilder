using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// The Header object is a name/value pair that represents an HTTP header.
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#header">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#header</a>
    /// </summary>
    public class Header
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <param name="value">The header value.</param>
        public Header(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// The header name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The header value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; }
    }
}
