
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call
    /// </summary>
    public enum ToolsGoogleSheetsIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        AppendValues,
        /// <summary>
        /// 
        /// </summary>
        BatchRead,
        /// <summary>
        /// 
        /// </summary>
        BatchWrite,
        /// <summary>
        /// 
        /// </summary>
        ClearValues,
        /// <summary>
        /// 
        /// </summary>
        ReadValues,
        /// <summary>
        /// 
        /// </summary>
        WriteValues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsGoogleSheetsIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsGoogleSheetsIntegrationDefUpdateMethod.AppendValues => "append_values",
                ToolsGoogleSheetsIntegrationDefUpdateMethod.BatchRead => "batch_read",
                ToolsGoogleSheetsIntegrationDefUpdateMethod.BatchWrite => "batch_write",
                ToolsGoogleSheetsIntegrationDefUpdateMethod.ClearValues => "clear_values",
                ToolsGoogleSheetsIntegrationDefUpdateMethod.ReadValues => "read_values",
                ToolsGoogleSheetsIntegrationDefUpdateMethod.WriteValues => "write_values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "append_values" => ToolsGoogleSheetsIntegrationDefUpdateMethod.AppendValues,
                "batch_read" => ToolsGoogleSheetsIntegrationDefUpdateMethod.BatchRead,
                "batch_write" => ToolsGoogleSheetsIntegrationDefUpdateMethod.BatchWrite,
                "clear_values" => ToolsGoogleSheetsIntegrationDefUpdateMethod.ClearValues,
                "read_values" => ToolsGoogleSheetsIntegrationDefUpdateMethod.ReadValues,
                "write_values" => ToolsGoogleSheetsIntegrationDefUpdateMethod.WriteValues,
                _ => null,
            };
        }
    }
}