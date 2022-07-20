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
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("name")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("name")]
#endif
        public string Name { get; }

        /// <summary>
        /// The header value.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("value")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("value")]
#endif
        public string Value { get; }
    }
}