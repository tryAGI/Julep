
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of computer environment to control.
    /// </summary>
    public enum ResponsesComputerToolEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        Browser,
        /// <summary>
        /// 
        /// </summary>
        Mac,
        /// <summary>
        /// 
        /// </summary>
        Ubuntu,
        /// <summary>
        /// 
        /// </summary>
        Windows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesComputerToolEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesComputerToolEnvironment value)
        {
            return value switch
            {
                ResponsesComputerToolEnvironment.Browser => "browser",
                ResponsesComputerToolEnvironment.Mac => "mac",
                ResponsesComputerToolEnvironment.Ubuntu => "ubuntu",
                ResponsesComputerToolEnvironment.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesComputerToolEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "browser" => ResponsesComputerToolEnvironment.Browser,
                "mac" => ResponsesComputerToolEnvironment.Mac,
                "ubuntu" => ResponsesComputerToolEnvironment.Ubuntu,
                "windows" => ResponsesComputerToolEnvironment.Windows,
                _ => null,
            };
        }
    }
}