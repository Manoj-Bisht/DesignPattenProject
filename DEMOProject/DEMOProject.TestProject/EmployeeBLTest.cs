using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEMOProject.BL;
using DEMOProject.InterfaceDefination;

namespace DEMOProject.TestProject
{
    [TestClass]
    public class EmployeeBLTest
    {
        [TestMethod]
        public void SaveTest()
        {
            //LoggerFactory.LoggerFactory factory = new LoggerFactory.LoggerFactory();
            //ILogger logger = factory.GetLogger("aa");

            ILogger logger = new TestLogger();

            EmployeeBL employee = new EmployeeBL(logger);
            Assert.AreEqual(employee.Save(), "MyLogger");

        }
    }

    public class TestLogger : ILogger
    {
        public string Debug(string message)
        {
            return "MyLogger";
        }
    }
}
