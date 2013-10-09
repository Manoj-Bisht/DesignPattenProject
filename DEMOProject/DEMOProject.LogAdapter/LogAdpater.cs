using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMOProject.InterfaceDefination;

namespace DEMOProject.LogAdapter
{
    public class LogAdpater : ILogger
    {
        ExternalLogger.ExternalLogger logger = new ExternalLogger.ExternalLogger();
        public string Debug(string message)
        {
            return(logger.LogExternal());
        }
    }
}
