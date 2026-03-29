
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call
    /// </summary>
    public enum ToolsGoogleSheetsIntegrationDefMethod
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
    public static class ToolsGoogleSheetsIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsGoogleSheetsIntegrationDefMethod.AppendValues => "append_values",
                ToolsGoogleSheetsIntegrationDefMethod.BatchRead => "batch_read",
                ToolsGoogleSheetsIntegrationDefMethod.BatchWrite => "batch_write",
                ToolsGoogleSheetsIntegrationDefMethod.ClearValues => "clear_values",
                ToolsGoogleSheetsIntegrationDefMethod.ReadValues => "read_values",
                ToolsGoogleSheetsIntegrationDefMethod.WriteValues => "write_values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "append_values" => ToolsGoogleSheetsIntegrationDefMethod.AppendValues,
                "batch_read" => ToolsGoogleSheetsIntegrationDefMethod.BatchRead,
                "batch_write" => ToolsGoogleSheetsIntegrationDefMethod.BatchWrite,
                "clear_values" => ToolsGoogleSheetsIntegrationDefMethod.ClearValues,
                "read_values" => ToolsGoogleSheetsIntegrationDefMethod.ReadValues,
                "write_values" => ToolsGoogleSheetsIntegrationDefMethod.WriteValues,
                _ => null,
            };
        }
    }
}