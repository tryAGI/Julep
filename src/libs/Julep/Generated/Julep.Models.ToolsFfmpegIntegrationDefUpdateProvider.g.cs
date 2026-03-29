
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "ffmpeg"<br/>
    /// Default Value: ffmpeg
    /// </summary>
    public enum ToolsFfmpegIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Ffmpeg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsFfmpegIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsFfmpegIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsFfmpegIntegrationDefUpdateProvider.Ffmpeg => "ffmpeg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsFfmpegIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "ffmpeg" => ToolsFfmpegIntegrationDefUpdateProvider.Ffmpeg,
                _ => null,
            };
        }
    }
}