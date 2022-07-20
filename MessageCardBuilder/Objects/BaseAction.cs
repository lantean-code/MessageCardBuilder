namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// The base type for all actions.
    /// </summary>
    public abstract class BaseAction : IAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAction"/> class.
        /// </summary>
        /// <param name="type">The type of the action.</param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        protected BaseAction(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <inheritdoc />
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("@type")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("@type")]
#endif
        public string Type { get; }

        /// <inheritdoc/>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("name")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("name")]
#endif
        public string Name { get; }
    }
}
