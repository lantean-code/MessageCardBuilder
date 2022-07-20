#if SYSTEMTEXTJSON || DEBUG
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MessageCard.Builder.Converters.SystemTextJson
{
    internal class EnumMemberJsonConverter : JsonConverterFactory
    {
        private static readonly Type _converterType = typeof(EnumMemberConverter<>);

        public override bool CanConvert(Type typeToConvert)
        {
            if (!typeToConvert.IsEnum)
            {
                return false;
            }
            var enumMembers =  typeToConvert.GetFields().Where(m => m.GetCustomAttribute<EnumMemberAttribute>() != null);
            return enumMembers.Any();
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var converter = (JsonConverter?)Activator.CreateInstance(_converterType.MakeGenericType(typeToConvert));
            return converter;
        }

        private sealed class EnumMemberConverter<T> : JsonConverter<T> where T : struct
        {
            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var value = reader.GetString();
                var enumType = typeof(T);
                foreach (var name in Enum.GetNames(enumType))
                {
                    var enumMemberAttribute = enumType.GetField(name).GetCustomAttribute<EnumMemberAttribute>(true);
                    if (enumMemberAttribute is null)
                    {
                        continue;
                    }
                    if (enumMemberAttribute.Value == value)
                    {
                        return (T)Enum.Parse(enumType, name);
                    }
                }

                Enum.TryParse<T>(value, out var val);

                return val;
            }

            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                var enumType = typeof(T);
                string valueToWrite = value.ToString();
                var enumMemberAttribute = enumType.GetField(valueToWrite).GetCustomAttribute<EnumMemberAttribute>(true);
                if (enumMemberAttribute is null)
                {
                    writer.WriteStringValue(valueToWrite);
                }
                else
                {
                    writer.WriteStringValue(enumMemberAttribute.Value);
                }
            }
        }
    }
}
#endif