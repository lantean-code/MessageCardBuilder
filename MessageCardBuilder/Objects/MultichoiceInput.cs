using System.Collections.Generic;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Use this input type when you need users to select from a list of pre-defined choices, such as a bug status, yes/no/maybe, etc.
    ///
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#multichoiceinput">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#multichoiceinput</a>
    /// </summary>
    public class MultiChoiceInput : Input
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiChoiceInput"/> class.
        /// </summary>
        /// <param name="id">Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.</param>
        /// <param name="title">Defines a title for the input.</param>
        /// <param name="choices">Defines the values that can be selected for the multi choice input.</param>
        /// <param name="multiSelect">If set to true, indicates that the user can select more than one choice. The specified choices will be displayed as a list of checkboxes.</param>
        /// <param name="style">When isMultiSelect is false, setting the style property to expanded will instruct the host application to try and display all choices on the screen, typically using a set of radio buttons.</param>
        /// <param name="required">Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.</param>
        /// <param name="initialValue">Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.</param>
        public MultiChoiceInput(
            string id,
            string title,
            IEnumerable<Choice> choices,
            bool multiSelect,
            Style style,
            bool? required = null,
            string? initialValue = null) : base("MultichoiceInput", id, title, required, initialValue)
        {
            Choices = choices;
            MultiSelect = multiSelect;
            Style = style;
        }

        /// <summary>
        /// Defines the values that can be selected for the multi choice input.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("choices")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("choices")]
#endif
        public IEnumerable<Choice> Choices { get; }

        /// <summary>
        /// If set to true, indicates that the user can select more than one choice. The specified choices will be displayed as a list of checkboxes.
        ///
        /// Default value is false.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("isMultiSelect")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("isMultiSelect")]
#endif
        public bool MultiSelect { get; }

        /// <summary>
        /// When isMultiSelect is false, setting the style property to expanded will instruct the host application to try and display all choices on the screen, typically using a set of radio buttons.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("style")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("style")]
#endif
        public Style Style { get; }
    }
}