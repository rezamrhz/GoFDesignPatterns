using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SOLID.Diagnostics.Logger
{
    public interface ILoggerPrefix
    {
        string PrefixMessageLogger { get; }
        string LogFolderBase { get; }
    }
}
