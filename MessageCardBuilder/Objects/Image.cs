namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Defines an image as used by the heroImage and images property of a section.
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#image-object">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#image-object</a>
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        /// <param name="uri">The URL to the image.</param>
        /// <param name="title">A short description of the image.</param>
        public Image(string uri, string title)
        {
            Uri = uri;
            Title = title;
        }

        /// <summary>
        /// The URL to the image.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("image")]
#elif SYSTEMTEXTJSON || DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("image")]
#endif
        public string Uri { get; }

        /// <summary>
        /// A short description of the image. Typically, title is displayed in a tooltip as the user hovers their mouse over the image.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("title")]
#elif SYSTEMTEXTJSON || DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("title")]
#endif
        public string Title { get; }
    }
}