#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsRemoteBrowserIntegrationDefUpdateMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod?>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod? Read(
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
                        return global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
