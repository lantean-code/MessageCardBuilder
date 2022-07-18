using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Use this input type when you need users to provide a date and or a time, such as for a task's due date.
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#example-dateinput">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#example-dateinput</a>
    /// </summary>
    public class DateInput : Input
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateInput"/> class.
        /// </summary>
        /// <param name="id">Uniquely identifies the input so it is possible to reference it in the URL or body of an <see cref="HttpPostAction" /> action.</param>
        /// <param name="title">Defines a title for the input.</param>
        /// <param name="includeTime">Indicates whether the date input should allow for the selection of a time in addition to the date.</param>
        /// <param name="required">Indicates whether users are required to type a value before they are able to take an action that would take the value of the input as a parameter.</param>
        /// <param name="initialValue">Defines the initial value of the input.  For multi-choice inputs, value must be equal to the value property of one of the input's choices.</param>
        public DateInput(
            string id,
            string title,
            bool includeTime,
            bool? required = null,
            string? initialValue = null) : base("DateInput", id, title, required, initialValue)
        {
            IncludeTime = includeTime;
        }

        /// <summary>
        /// Indicates whether the date input should allow for the selection of a time in addition to the date.
        /// </summary>
        [JsonPropertyName("includeTime")]
        public bool IncludeTime { get; set; }
    }
}
