using System.Runtime.Serialization;

namespace MessageCard.Builder.Objects
{
    public enum Style
    {
        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "expanded")]
        Expanded
    }
}