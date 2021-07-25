using DP.SOLID.Diagnostics.Logger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    //This static class used for call log methods by clients
    public static class LogManager
    {
        private static ILogger hddLogger;

        static LogManager()
        {
            hddLogger = new HDDLogger();
        }


        public static void Debug(params string[] messages)
        {
            hddLogger.LogLevel = LogLevel.Debug;
            hddLogger.Debug(string.Concat(messages));
        }

        public static void Error(params string[] messages)
        {
            hddLogger.LogLevel = LogLevel.Error;
            hddLogger.Error(string.Concat(messages));
        }

        public static void Info(params string[] messages)
        {
            hddLogger.LogLevel = LogLevel.Information;
            hddLogger.Info(string.Concat(messages));
        }

        public static void Info(string msg, object data)
        {
            hddLogger.LogLevel = LogLevel.Information;
            hddLogger.Info(msg, data);
        }

        public static void Warn(params string[] messages)
        {
            hddLogger.LogLevel = LogLevel.Warning;
            hddLogger.Warn(string.Concat(messages));
        }

        public static void Warn(string msg, object data)
        {
            hddLogger.LogLevel = LogLevel.Warning;
            hddLogger.Warn(msg, data);
        }
    }
}
