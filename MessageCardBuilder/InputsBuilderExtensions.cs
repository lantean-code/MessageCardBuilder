using MessageCard.Builder.Objects;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    /// <summary>
    /// Inputs builder extensions.
    /// </summary>
    public static class InputsBuilderExtensions
    {
        /// <summary>
        /// Adds a date input.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="input">The date input.</param>
        /// <returns></returns>
        public static IInputsBuilder AddDateInput(this IInputsBuilder builder, DateInput input)
        {
            return builder.AddInput(input);
        }

        /// <summary>
        /// Adds a date input.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="id">Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.</param>
        /// <param name="title">Defines a title for the input.</param>
        /// <param name="includeTime">Indicates whether the date input should allow for the selection of a time in addition to the date.</param>
        /// <param name="required">Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.</param>
        /// <param name="initialValue">Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.</param>
        /// <returns></returns>
        public static IInputsBuilder AddDateInput(this IInputsBuilder builder, string id, string title, bool includeTime, bool? required = null, string? initialValue = null)
        {
            var input = new DateInput(id, title, includeTime, required, initialValue);
            return builder.AddDateInput(input);
        }

        /// <summary>
        /// Adds a multichoice input.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="input">The multichoice input.</param>
        /// <returns></returns>
        public static IInputsBuilder AddMutiChoiceInput(this IInputsBuilder builder, MultiChoiceInput input)
        {
            return builder.AddInput(input);
        }

        /// <summary>
        /// Adds a multichoice input.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="id">Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.</param>
        /// <param name="title">Defines a title for the input.</param>
        /// <param name="choices">Defines the values that can be selected for the multi choice input.</param>
        /// <param name="multiSelect">If set to true, indicates that the user can select more than one choice. The specified choices will be displayed as a list of checkboxes.</param>
        /// <param name="style">When isMultiSelect is false, setting the style property to expanded will instruct the host application to try and display all choices on the screen, typically using a set of radio buttons.</param>
        /// <param name="required">Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.</param>
        /// <param name="initialValue">Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.</param>
        /// <returns></returns>
        public static IInputsBuilder AddMutiChoiceInput(this IInputsBuilder builder, string id, string title, IEnumerable<Choice> choices, bool multiSelect, Style style, bool? required = null, string? initialValue = null)
        {
            var input = new MultiChoiceInput(id, title, choices, multiSelect, style, required, initialValue);
            return builder.AddMutiChoiceInput(input);
        }

        /// <summary>
        /// Adds a text input.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="input">The text input.</param>
        /// <returns></returns>
        public static IInputsBuilder AddTextInput(this IInputsBuilder builder, TextInput input)
        {
            return builder.AddInput(input);
        }

        /// <summary>
        /// Adds a text input.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="id">Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.</param>
        /// <param name="title">Defines a title for the input.</param>
        /// <param name="multiline">Indicates whether the text input should accept multiple lines of text.</param>
        /// <param name="maxLength">Indicates the maximum number of characters that can be entered.</param>
        /// <param name="required">Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.</param>
        /// <param name="initialValue">Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.</param>
        /// <returns></returns>
        public static IInputsBuilder AddTextInput(this IInputsBuilder builder, string id, string title, bool multiline, int maxLength, bool? required = null, string? initialValue = null)
        {
            var input = new TextInput(id, title, multiline, maxLength, required, initialValue);
            return builder.AddTextInput(input);
        }
    }
}
