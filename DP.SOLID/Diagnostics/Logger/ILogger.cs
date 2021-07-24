using System;

namespace DP.SOLID.Diagnostics.Logger
{
    public interface ILogger
    {
        LogLevel LogLevel { get; set; }
        LogTarget LogTarget { get; }
        void Info(string msg);
        void Info(string msg, object data);
        void Warn(string msg);
        void Warn(string msg, object data);
        void Debug(string msg);
        void Error(string msg);
    }
}
