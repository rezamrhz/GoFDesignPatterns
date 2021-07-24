using System;

namespace DP.SOLID.Diagnostics.Logger
{
    [Flags]
    public enum LogLevel
    {
        None = 0,
        Debug = 1,
        Information = 2,
        Error = 4,
        Warning = 8,
    }
}
