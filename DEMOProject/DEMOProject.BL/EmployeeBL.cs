using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMOProject.InterfaceDefination;
using System.Configuration;

namespace DEMOProject.BL
{
    public class EmployeeBL
    {
        //ILogger logger = new MyLogger.MyLogger();
        LoggerFactory.LoggerFactory factory ;
        ILogger logger ;

        public EmployeeBL(ILogger logger)
        {
            
            this.logger = logger; 
        }

        public string Save()
        {
            string message = logger.Debug("My Logger");
            return message;
        }
    }
}
