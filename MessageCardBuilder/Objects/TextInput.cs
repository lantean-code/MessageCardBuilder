using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Use this input type when you need users to provide free text, such as the response to a survey question.
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#textinput">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#textinput</a>
    /// </summary>
    public class TextInput : Input
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextInput"/> class.
        /// </summary>
        /// <param name="id">Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.</param>
        /// <param name="title">Defines a title for the input.</param>
        /// <param name="multiline">Indicates whether the text input should accept multiple lines of text.</param>
        /// <param name="maxLength">Indicates the maximum number of characters that can be entered.</param>
        /// <param name="required">Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.</param>
        /// <param name="initialValue">Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.</param>
        public TextInput(
            string id,
            string title,
            bool multiline,
            int maxLength,
            bool? required = null,
            string? initialValue = null) : base("TextInput", id, title, required, initialValue)
        {
            Multiline = multiline;
            MaxLength = maxLength;
        }

        /// <summary>
        /// Indicates whether the text input should accept multiple lines of text.
        /// </summary>
        [JsonPropertyName("isMultiline")]
        public bool Multiline { get; }

        /// <summary>
        /// Indicates the maximum number of characters that can be entered.
        /// </summary>
        [JsonPropertyName("maxLength")]
        public int MaxLength { get; }
    }
}
