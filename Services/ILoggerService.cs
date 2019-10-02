using System;
using System.Collections.Generic;
using System.Text;

namespace sample_dotnet_logger.Services
{
    public interface ILoggerService
    {
        /// <summary>
        ///   Logs the information.
        /// </summary>
        /// <param name="message">
        ///   The message.
        /// </param>
        void LogInfo(string message);

        /// <summary>
        ///   Logs the warn.
        /// </summary>
        /// <param name="message">
        ///   The message.
        /// </param>
        void LogWarn(string message);

        /// <summary>
        ///   Logs the debug.
        /// </summary>
        /// <param name="message">
        ///   The message.
        /// </param>
        void LogDebug(string message);

        /// <summary>
        ///   Logs the error.
        /// </summary>
        /// <param name="message">
        ///   The message.
        /// </param>
        void LogError(string message);
    }
}
