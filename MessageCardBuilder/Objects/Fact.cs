namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Facts are a very important component of a section. They often contain the information that really matters to the user.
    /// </summary>
    public class Fact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fact"/> class.
        /// </summary>
        /// <param name="name">The name of the fact. Do keep fact names short. Avoid using Markdown formatting.</param>
        /// <param name="value">The value of the fact.</param>
        public Fact(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// The name of the fact. Do keep fact names short. Avoid using Markdown formatting.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("name")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("name")]
#endif
        public string Name { get; }

        /// <summary>
        /// The value of the fact.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("value")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("value")]
#endif
        public string Value { get; }
    }
}