using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SOLID.Diagnostics.Logger
{
    public class HDDLogger : LoggerBase, ILogger
    {
        public HDDLogger()
            : base(LogTarget.HDD)
        {

        }
        protected override void LogAnyway(LogLevel logLevel, string msg, object data)
        {
            Console.WriteLine(msg);
        }
    }
}
