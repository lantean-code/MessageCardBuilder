using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Opens a URI in a separate browser or app.
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#openuri-action">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#openuri-action</a>
    /// </summary>
    public class OpenUriAction : BaseAction, IEmbeddableAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenUriAction"/> class.
        /// </summary>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="targets">The targets property is a collection of name/value pairs that defines one URI per target operating system.</param>
        public OpenUriAction(
            string name,
            IEnumerable<Target> targets) : base("OpenUri", name)
        {
            Targets = targets;
        }

        /// <summary>
        /// The targets property is a collection of name/value pairs that defines one URI per target operating system.
        /// </summary>
        [JsonPropertyName("targets")]
        public IEnumerable<Target> Targets { get; }
    }
}
