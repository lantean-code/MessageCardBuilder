namespace MessageCard.Builder
{
    /// <summary>
    /// An action that can be added to message card or a section.
    /// </summary>
    public interface IAction
    {
        /// <summary>
        /// The type of the action.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// The name property defines the text that will be displayed on screen for the action.
        /// </summary>
        string Name { get; }
    }
}