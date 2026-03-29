#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class TasksPromptStepToolsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.TasksPromptStepTools?>
    {
        /// <inheritdoc />
        public override global::Julep.TasksPromptStepTools? Read(
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
                        return global::Julep.TasksPromptStepToolsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.TasksPromptStepTools)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.TasksPromptStepTools?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.TasksPromptStepTools? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.TasksPromptStepToolsExtensions.ToValueString(value.Value));
            }
        }
    }
}
