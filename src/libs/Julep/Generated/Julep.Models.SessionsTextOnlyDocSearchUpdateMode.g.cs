
#nullable enable

namespace Julep
{
    /// <summary>
    /// The mode to use for the search.<br/>
    /// Default Value: text
    /// </summary>
    public enum SessionsTextOnlyDocSearchUpdateMode
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsTextOnlyDocSearchUpdateModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsTextOnlyDocSearchUpdateMode value)
        {
            return value switch
            {
                SessionsTextOnlyDocSearchUpdateMode.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsTextOnlyDocSearchUpdateMode? ToEnum(string value)
        {
            return value switch
            {
                "text" => SessionsTextOnlyDocSearchUpdateMode.Text,
                _ => null,
            };
        }
    }
}