using System.Runtime.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// The content type of the body.
    /// </summary>
    public enum BodyContentType
    {
        /// <summary>
        /// application/json
        /// </summary>
        [EnumMember(Value = "application/json")]
        Json,

        /// <summary>
        /// application/x-www-form-urlencoded
        /// </summary>
        [EnumMember(Value = "application/x-www-form-urlencoded")]
        FormEncoded
    }
}