using System.Collections.Generic;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Presents additional UI that contains one or more Inputs, along with associated actions that can be either OpenUri or HttpPOST types.
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#actioncard-action">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#actioncard-action</a>
    /// </summary>
    public class ActionCardAction : BaseAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionCardAction"/> class.
        /// </summary>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="inputs">The inputs property defines the various inputs that will be displayed in the action card's UI.</param>
        /// <param name="actions">The actions property is an array of Action objects, that can be either of type OpenUri or HttpPOST.</param>
        public ActionCardAction(string name, IEnumerable<Input> inputs, IEnumerable<IEmbeddableAction> actions) : base("ActionCard", name)
        {
            Inputs = inputs;
            Actions = actions;
        }

        /// <summary>
        /// The inputs property defines the various inputs that will be displayed in the action card's UI.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("inputs")]
#elif SYSTEMTEXTJSON || DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("inputs")]
#endif
        public IEnumerable<Input> Inputs { get; }

        /// <summary>
        /// The actions property is an array of Action objects, that can be either of type OpenUri or HttpPOST. The actions property of an ActionCard action cannot contain another ActionCard action.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("actions")]
#elif SYSTEMTEXTJSON || DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("actions")]
#endif
        public IEnumerable<IEmbeddableAction> Actions { get; }
    }
}