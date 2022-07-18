using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    internal class ActionConverter : JsonConverter<IAction>
    {
        public override IAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, IAction value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ActionCardAction action:
                    JsonSerializer.Serialize(writer, action, options);
                    break;

                case HttpPostAction action:
                    JsonSerializer.Serialize(writer, action, options);
                    break;

                case OpenUriAction action:
                    JsonSerializer.Serialize(writer, action, options);
                    break;

                default:
                    throw new ArgumentException("It is not a recognized type.", nameof(value));
            }
        }
    }
}