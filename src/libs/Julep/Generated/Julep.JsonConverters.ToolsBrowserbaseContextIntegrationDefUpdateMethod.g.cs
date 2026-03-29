#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsBrowserbaseContextIntegrationDefUpdateMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethodExtensions.ToValueString(value));
        }
    }
}
