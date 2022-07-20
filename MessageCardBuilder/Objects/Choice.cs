namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#multichoiceinput">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#multichoiceinput</a>
    /// </summary>
    public class Choice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Choice"/> class.
        /// </summary>
        /// <param name="display">The choice display name.</param>
        /// <param name="value">The choice value.</param>
        public Choice(string display, string value)
        {
            Display = display;
            Value = value;
        }

        /// <summary>
        /// The choice display name.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("display")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("display")]
#endif
        public string Display { get; }

        /// <summary>
        /// The choice value.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("value")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("value")]
#endif
        public string Value { get; }
    }
}