
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the file path. Always `file_path`.
    /// </summary>
    public enum ResponsesFilePathType
    {
        /// <summary>
        /// 
        /// </summary>
        FilePath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFilePathTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFilePathType value)
        {
            return value switch
            {
                ResponsesFilePathType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFilePathType? ToEnum(string value)
        {
            return value switch
            {
                "file_path" => ResponsesFilePathType.FilePath,
                _ => null,
            };
        }
    }
}