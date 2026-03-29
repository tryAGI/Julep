#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsGoogleSheetsIntegrationDefUpdateProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider Read(
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
                        return global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProviderExtensions.ToValueString(value));
        }
    }
}
