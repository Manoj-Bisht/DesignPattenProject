using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMOProject.InterfaceDefination;

namespace DEMOProject.MyLogger
{
    public class MyLogger : ILogger
    {
        public string Debug(string message)
        {
            throw new Exception("Logger not available");
            return "MyLogger";
        }
    }
}
