#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class TasksSetStepEnumKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.TasksSetStepEnumKind>
    {
        /// <inheritdoc />
        public override global::Julep.TasksSetStepEnumKind Read(
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
                        return global::Julep.TasksSetStepEnumKindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.TasksSetStepEnumKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.TasksSetStepEnumKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.TasksSetStepEnumKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.TasksSetStepEnumKindExtensions.ToValueString(value));
        }
    }
}
