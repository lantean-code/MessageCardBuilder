using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    public class ActionCardAction : BaseAction
    {
        public ActionCardAction(string name, IEnumerable<Input> inputs, IEnumerable<IEmbeddableAction> actions) : base("ActionCard", name)
        {
            Inputs = inputs;
            Actions = actions;
        }

        [JsonPropertyName("inputs")]
        public IEnumerable<Input> Inputs { get; }

        [JsonPropertyName("actions")]
        public IEnumerable<IEmbeddableAction> Actions { get; }
    }
}
