
#nullable enable

namespace Julep
{
    /// <summary>
    /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
    /// </summary>
    public enum ResponsesClickButton
    {
        /// <summary>
        /// 
        /// </summary>
        Back,
        /// <summary>
        /// 
        /// </summary>
        Forward,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
        /// <summary>
        /// 
        /// </summary>
        Wheel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesClickButtonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesClickButton value)
        {
            return value switch
            {
                ResponsesClickButton.Back => "back",
                ResponsesClickButton.Forward => "forward",
                ResponsesClickButton.Left => "left",
                ResponsesClickButton.Right => "right",
                ResponsesClickButton.Wheel => "wheel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesClickButton? ToEnum(string value)
        {
            return value switch
            {
                "back" => ResponsesClickButton.Back,
                "forward" => ResponsesClickButton.Forward,
                "left" => ResponsesClickButton.Left,
                "right" => ResponsesClickButton.Right,
                "wheel" => ResponsesClickButton.Wheel,
                _ => null,
            };
        }
    }
}