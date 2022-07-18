#if NEWTONSOFTJSON || DEBUG
using MessageCard.Builder.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder.Converters.NewtonsoftJson
{
    internal class RuntimeTypeJsonConverter : JsonConverter
    {
        private static readonly HashSet<Type> _typesToConvert = new HashSet<Type>
        {
            typeof(IAction),
            typeof(Input),
            typeof(IEmbeddableAction)
        };

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            var type = value?.GetType();
            if (type is null)
            {
                return;
            }
            serializer.Serialize(writer, value, type);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return _typesToConvert.Contains(objectType);
        }
    }
}
#endif