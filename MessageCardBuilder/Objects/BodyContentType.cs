using System.Runtime.Serialization;

namespace MessageCard.Builder.Objects
{
    public enum BodyContentType
    {
        [EnumMember(Value = "application/json")]
        Json,
        [EnumMember(Value = "application/x-www-form-urlencoded")]
        FormEncoded
    }
}