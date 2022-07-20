namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// The base type for all inputs.
    /// </summary>
    public abstract class Input
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Input"/> class.
        /// </summary>
        /// <param name="type">The type of the input.</param>
        /// <param name="id">Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.</param>
        /// <param name="title">Defines a title for the input.</param>
        /// <param name="required">Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.</param>
        /// <param name="initialValue">Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.</param>
        protected Input(string type, string id, string title, bool? required = null, string? initialValue = null)
        {
            Id = id;
            Required = required;
            Title = title;
            InitialValue = initialValue;
            Type = type;
        }

        /// <summary>
        /// The type of the input.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("@type")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("@type")]
#endif
        public string Type { get; }

        /// <summary>
        /// Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("id")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("id")]
#endif
        public string Id { get; }

        /// <summary>
        /// Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("isRequired")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("isRequired")]
#endif
        public bool? Required { get; }

        /// <summary>
        /// Defines a title for the input.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("title")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("title")]
#endif
        public string Title { get; }

        /// <summary>
        /// Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("value")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("value")]
#endif
        public string? InitialValue { get; }
    }
}