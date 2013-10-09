using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMOProject.InterfaceDefination;

namespace DEMOProject.LoggerFactory
{
    public class LoggerFactory
    {
        public ILogger GetLogger(string logIdentifier)
        {
            ILogger logger = new MyLogger.MyLogger();

            if (logIdentifier == "MyLogger")
            {
                logger = new MyLogger.MyLogger();
            }
            else if (logIdentifier == "ExternalLogger")
            {
                logger = new LogAdapter.LogAdpater();
            }
            return logger;
        }
    }
}
