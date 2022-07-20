using System.Runtime.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// The style of the multi choice input.
    /// </summary>
    public enum Style
    {
        /// <summary>
        /// Normal style
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal,

        /// <summary>
        /// Will instruct the host application to try and display all choices on the screen.
        /// </summary>
        [EnumMember(Value = "expanded")]
        Expanded
    }
}