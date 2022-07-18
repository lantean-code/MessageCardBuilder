using MessageCard.Builder.Objects;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    public static class InputsBuilderExtensions
    {
        public static IInputsBuilder AddDateInput(this IInputsBuilder builder, DateInput input)
        {
            return builder.AddInput(input);
        }

        public static IInputsBuilder AddDateInput(this IInputsBuilder builder, string id, string title, bool includeTime, bool? required = null, string? initialValue = null)
        {
            var input = new DateInput(id, title, includeTime, required, initialValue);
            return builder.AddDateInput(input);
        }

        public static IInputsBuilder AddMutiChoiceInput(this IInputsBuilder builder, MultiChoiceInput input)
        {
            return builder.AddInput(input);
        }

        public static IInputsBuilder AddMutiChoiceInput(this IInputsBuilder builder, string id, string title, IEnumerable<Choice> choices, bool multiSelect, Style style, bool? required = null, string? initialValue = null)
        {
            var input = new MultiChoiceInput(id, title, choices, multiSelect, style, required, initialValue);
            return builder.AddMutiChoiceInput(input);
        }

        public static IInputsBuilder AddTextInput(this IInputsBuilder builder, TextInput input)
        {
            return builder.AddInput(input);
        }

        public static IInputsBuilder AddTextInput(this IInputsBuilder builder, string id, string title, bool multiline, int maxLength, bool? required = null, string? initialValue = null)
        {
            var input = new TextInput(id, title, multiline, maxLength, required, initialValue);
            return builder.AddTextInput(input);
        }
    }
}
