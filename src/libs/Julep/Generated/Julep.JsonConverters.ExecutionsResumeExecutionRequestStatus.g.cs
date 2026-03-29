#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExecutionsResumeExecutionRequestStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ExecutionsResumeExecutionRequestStatus>
    {
        /// <inheritdoc />
        public override global::Julep.ExecutionsResumeExecutionRequestStatus Read(
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
                        return global::Julep.ExecutionsResumeExecutionRequestStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ExecutionsResumeExecutionRequestStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ExecutionsResumeExecutionRequestStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ExecutionsResumeExecutionRequestStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ExecutionsResumeExecutionRequestStatusExtensions.ToValueString(value));
        }
    }
}
