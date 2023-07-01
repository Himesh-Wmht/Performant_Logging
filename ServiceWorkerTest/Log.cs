namespace Performant_Logging
{
    public static partial class Log
    {
        [LoggerMessage(20, LogLevel.Information, "Weather forecast requested at {date}.")]
        public static partial void WeatherForcastRequested(this ILogger logger, DateTime date);
    }
}
