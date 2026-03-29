#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsBrowserbaseListSessionsIntegrationDefUpdateMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod Read(
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
                        return global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethodExtensions.ToValueString(value));
        }
    }
}
