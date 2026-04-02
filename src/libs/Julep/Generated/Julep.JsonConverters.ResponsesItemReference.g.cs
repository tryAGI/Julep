#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesItemReferenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ResponsesItemReference>
    {
        /// <inheritdoc />
        public override global::Julep.ResponsesItemReference Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("queries")) __score2++;
            if (__jsonProps.Contains("results")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pending_safety_checks")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("arguments")) __score6++;
            if (__jsonProps.Contains("call_id")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("id")) __score7++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::Julep.ResponsesInputMessageResource? inputMessageResource = default;
            global::Julep.ResponsesOutputMessage? outputMessage = default;
            global::Julep.ResponsesFileSearchToolCall? fileSearchToolCall = default;
            global::Julep.ResponsesComputerToolCall? computerToolCall = default;
            global::Julep.ResponsesComputerToolCallOutputResource? computerToolCallOutputResource = default;
            global::Julep.ResponsesWebSearchToolCall? webSearchToolCall = default;
            global::Julep.ResponsesFunctionToolCall? functionToolCall = default;
            global::Julep.ResponsesFunctionToolCallOutputResource? functionToolCallOutputResource = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        inputMessageResource = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesInputMessageResource>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        outputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesOutputMessage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        fileSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesFileSearchToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        computerToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesComputerToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        computerToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesComputerToolCallOutputResource>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        webSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesWebSearchToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesFunctionToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        functionToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesFunctionToolCallOutputResource>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputMessageResource == null && outputMessage == null && fileSearchToolCall == null && computerToolCall == null && computerToolCallOutputResource == null && webSearchToolCall == null && functionToolCall == null && functionToolCallOutputResource == null)
            {
                try
                {
                    inputMessageResource = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesInputMessageResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesOutputMessage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesFileSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesComputerToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesComputerToolCallOutputResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesWebSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesFunctionToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::Julep.ResponsesFunctionToolCallOutputResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Julep.ResponsesItemReference(
                inputMessageResource,

                outputMessage,

                fileSearchToolCall,

                computerToolCall,

                computerToolCallOutputResource,

                webSearchToolCall,

                functionToolCall,

                functionToolCallOutputResource
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ResponsesItemReference value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputMessageResource)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessageResource, typeof(global::Julep.ResponsesInputMessageResource), options);
            }
            else if (value.IsOutputMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessage, typeof(global::Julep.ResponsesOutputMessage), options);
            }
            else if (value.IsFileSearchToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchToolCall, typeof(global::Julep.ResponsesFileSearchToolCall), options);
            }
            else if (value.IsComputerToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCall, typeof(global::Julep.ResponsesComputerToolCall), options);
            }
            else if (value.IsComputerToolCallOutputResource)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutputResource, typeof(global::Julep.ResponsesComputerToolCallOutputResource), options);
            }
            else if (value.IsWebSearchToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolCall, typeof(global::Julep.ResponsesWebSearchToolCall), options);
            }
            else if (value.IsFunctionToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCall, typeof(global::Julep.ResponsesFunctionToolCall), options);
            }
            else if (value.IsFunctionToolCallOutputResource)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutputResource, typeof(global::Julep.ResponsesFunctionToolCallOutputResource), options);
            }
        }
    }
}