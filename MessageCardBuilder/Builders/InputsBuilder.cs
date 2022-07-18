using MessageCard.Builder.Objects;
using System.Collections.Generic;

namespace MessageCard.Builder.Builders
{
    internal class InputsBuilder : IInputsBuilder
    {
        private readonly List<Input> _inputs = new List<Input>();

        internal IReadOnlyList<Input> Build()
        {
            return _inputs.AsReadOnly();
        }

        public IInputsBuilder AddInput(Input input)
        {
            _inputs.Add(input);
            return this;
        }
    }
}