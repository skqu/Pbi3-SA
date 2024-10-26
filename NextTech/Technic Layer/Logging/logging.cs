using System;
using System.IO;
using System.Runtime.CompilerServices;

public class Logger
{
    private readonly string _logFilePath;

    /// <summary>
    /// Initializes a new instance of the <see cref="Logger"/> class.
    /// </summary>
    /// <param name="logFileName">The name of the log file. Defaults to "log.txt".</param>
    public Logger(string logFileName = "../../../log/log.txt")
    {
        _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logFileName);
    }

    /// <summary>
    /// Writes a log entry with specified level, message, caller class, caller method, and line number.
    /// </summary>
    /// <param name="level">The log level (e.g., INFO, WARNING, ERROR).</param>
    /// <param name="message">The message to log.</param>
    /// <param name="callerClass">The name of the calling class.</param>
    /// <param name="callerMethod">The name of the calling method.</param>
    /// <param name="lineNumber">The line number in the calling method.</param>
    private void WriteLog(string level, string message, string callerClass, string callerMethod, int lineNumber)
    {
        var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {callerClass}.{callerMethod} Line {lineNumber}: {message}";
        File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
    }

    /// <summary>
    /// Logs an informational message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="callerClass">Automatically captures the calling class name.</param>
    /// <param name="callerMethod">Automatically captures the calling method name.</param>
    /// <param name="lineNumber">Automatically captures the line number in the calling method.</param>
    public void Info(string message, 
                     [CallerFilePath] string callerClass = "", 
                     [CallerMemberName] string callerMethod = "", 
                     [CallerLineNumber] int lineNumber = 0)
    {
        WriteLog("INFO", message, Path.GetFileNameWithoutExtension(callerClass), callerMethod, lineNumber);
    }

    /// <summary>
    /// Logs a warning message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="callerClass">Automatically captures the calling class name.</param>
    /// <param name="callerMethod">Automatically captures the calling method name.</param>
    /// <param name="lineNumber">Automatically captures the line number in the calling method.</param>
    public void Warning(string message, 
                        [CallerFilePath] string callerClass = "", 
                        [CallerMemberName] string callerMethod = "", 
                        [CallerLineNumber] int lineNumber = 0)
    {
        WriteLog("WARNING", message, Path.GetFileNameWithoutExtension(callerClass), callerMethod, lineNumber);
    }

    /// <summary>
    /// Logs an error message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="callerClass">Automatically captures the calling class name.</param>
    /// <param name="callerMethod">Automatically captures the calling method name.</param>
    /// <param name="lineNumber">Automatically captures the line number in the calling method.</param>
    public void Error(string message, 
                      [CallerFilePath] string callerClass = "", 
                      [CallerMemberName] string callerMethod = "", 
                      [CallerLineNumber] int lineNumber = 0)
    {
        WriteLog("ERROR", message, Path.GetFileNameWithoutExtension(callerClass), callerMethod, lineNumber);
    }
}
