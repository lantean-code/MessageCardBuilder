namespace MessageCard.Builder.Objects
{
    public abstract class BaseAction : IAction
    {
        protected BaseAction(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary>
        /// The name property defines the text that will be displayed on screen for the action.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("@type")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("@type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The name property defines the text that will be displayed on screen for the action.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("name")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
