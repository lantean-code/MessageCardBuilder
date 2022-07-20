using System.Runtime.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Supported operating systems.
    /// </summary>
    public enum TargetOperatingSystem
    {
        /// <summary>
        /// The default operating system.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,

        /// <summary>
        /// The Windows operating system.
        /// </summary>
        [EnumMember(Value = "windows")]
        Windows,

        /// <summary>
        /// The iOS operating system.
        /// </summary>
        [EnumMember(Value = "iOS")]
        iOS,

        /// <summary>
        /// The Android operating system.
        /// </summary>
        [EnumMember(Value = "android")]
        Android,
    }
}