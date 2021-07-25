using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DP.SOLID.Diagnostics.Logger
{
    public abstract class LoggerBase : ILogger
    {
        private delegate void LoggerDelegate(LogLevel logLevel, string msg, object data);

        private LoggerDelegate InfoDelegate;
        private LoggerDelegate DebugDelegate;
        private LoggerDelegate ErrorDelegate;
        private LoggerDelegate WarnDelegate;

        private LogTarget logTarget;
        private LogLevel logLevel;

        public LoggerBase(LogTarget _logTarget)
        {
            logTarget = _logTarget;
            UpdateDelegates();
        }


        public LogLevel LogLevel
        {
            get { return logLevel; }
            set
            {
                logLevel = value;
                UpdateDelegates();
            }
        }

        public LogTarget LogTarget
        {
            get
            {
                return logTarget;
            }
        }

        protected abstract void LogAnyway(LogLevel logLevel, string msg, object data);

        private void EmptyDelegateHandler(LogLevel logLevel, string msg, object data) { }
        private void FunctionDelegateHandler(LogLevel logLevel, string msg, object data)
        {
            LogAnyway(logLevel, msg, data);
        }

        private void UpdateDelegates()
        {
            if (logLevel.HasFlag(LogLevel.Debug))
                DebugDelegate = FunctionDelegateHandler;
            else
                DebugDelegate = EmptyDelegateHandler;

            if (logLevel.HasFlag(LogLevel.Error))
                ErrorDelegate = FunctionDelegateHandler;
            else
                ErrorDelegate = EmptyDelegateHandler;

            if (logLevel.HasFlag(LogLevel.Information))
                InfoDelegate = FunctionDelegateHandler;
            else
                InfoDelegate = EmptyDelegateHandler;

            if (logLevel.HasFlag(LogLevel.Warning))
                WarnDelegate = FunctionDelegateHandler;
            else
                WarnDelegate = EmptyDelegateHandler;
        }

        public void Debug(string msg)
        {
            DebugDelegate(LogLevel.Debug, msg, null);
        }

        public void Error(string msg)
        {
            ErrorDelegate(LogLevel.Error, msg, null);
        }

        public void Info(string msg)
        {
            Info(msg, null);
        }

        public void Info(string msg, object data)
        {
            InfoDelegate(LogLevel.Information, msg, data);
        }

        public void Warn(string msg)
        {
            Warn(msg, null);
        }

        public void Warn(string msg, object data)
        {
            WarnDelegate(LogLevel.Warning, msg, data);
        }
    }
}
