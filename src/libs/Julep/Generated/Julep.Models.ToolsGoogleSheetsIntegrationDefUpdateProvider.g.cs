
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "google_sheets"<br/>
    /// Default Value: google_sheets
    /// </summary>
    public enum ToolsGoogleSheetsIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleSheets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsGoogleSheetsIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsGoogleSheetsIntegrationDefUpdateProvider.GoogleSheets => "google_sheets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_sheets" => ToolsGoogleSheetsIntegrationDefUpdateProvider.GoogleSheets,
                _ => null,
            };
        }
    }
}