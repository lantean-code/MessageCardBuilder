using System;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Opens an Outlook add-in task pane. If the add-in is not installed, the user is prompted to install the add-in with a single click.
    ///
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#invokeaddincommand-action">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#invokeaddincommand-action</a>
    /// </summary>
    public class InvokeAddInCommandAction : BaseAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeAddInCommandAction"/> class.
        /// </summary>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="addInId">Specifies the add-in ID of the required add-in. The add-in ID is found in the Id element in the add-in's manifest.</param>
        /// <param name="desktopCommandId">Specifies the ID of the add-in command button that opens the required task pane.</param>
        /// <param name="initializationContext">Optional. Developers may specify any valid JSON object in this field. The value is serialized into a string and made available to the add-in when the action is executed. This allows the action to pass initialization data to the add-in.</param>
        public InvokeAddInCommandAction(
            string name,
            Guid addInId,
            string desktopCommandId,
            object? initializationContext = null) : base("InvokeAddInCommand", name)
        {
            AddInId = addInId;
            DesktopCommandId = desktopCommandId;
            InitializationContext = initializationContext;
        }

        /// <summary>
        /// Specifies the add-in ID of the required add-in.
        /// The add-in ID is found in the Id element in the add-in's manifest.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("addInId")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("addInId")]
#endif
        public Guid AddInId { get; }

        /// <summary>
        /// Specifies the ID of the add-in command button that opens the
        /// required taskpane.The command button ID is found in the id attribute
        /// of the Control element that defines the button in the add-in's
        /// manifest. The specified Control element MUST be defined inside a
        /// MessageReadCommandSurface extension point, be of type Button, and
        /// the control's Action must be of type ShowTaskPane.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("desktopCommandId")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("desktopCommandId")]
#endif
        public string DesktopCommandId { get; }

        /// <summary>
        /// Optional. Developers may specify any valid JSON object in this
        /// field. The value is serialized into a string and made available to
        /// the add-in when the action is executed. This allows the action to
        /// pass initialization data to the add-in.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initializationContext")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initializationContext")]
#endif
        public object? InitializationContext { get; }
    }
}