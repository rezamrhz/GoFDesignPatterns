using System;

namespace DP.SOLID.Diagnostics.Logger
{
    [Flags]
    public enum LogTarget
    {
        None = 0,
        HDD = 1,
        EventViewer = 2,
        Database = 4,
    }
}
