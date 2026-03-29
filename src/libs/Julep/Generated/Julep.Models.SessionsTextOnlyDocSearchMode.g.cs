
#nullable enable

namespace Julep
{
    /// <summary>
    /// The mode to use for the search.<br/>
    /// Default Value: text
    /// </summary>
    public enum SessionsTextOnlyDocSearchMode
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsTextOnlyDocSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsTextOnlyDocSearchMode value)
        {
            return value switch
            {
                SessionsTextOnlyDocSearchMode.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsTextOnlyDocSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "text" => SessionsTextOnlyDocSearchMode.Text,
                _ => null,
            };
        }
    }
}