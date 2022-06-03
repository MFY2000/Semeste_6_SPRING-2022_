using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {


        ExtentReports extentTest = null;

        [ClassInitialize]
        public void TestInitialize()
        {

            Console.WriteLine("start");

            extentTest = new ExtentReports();
            extentTest.AttachReporter(new ExtentHtmlReporter(@"C:/Users/DarkJoker/Desktop/Semeste_6_FALL-2021_/6) Test Driven Development(TDD)_BM/ProjectSemester_Project/Semester_Project/Reports/Addition_{DateTime.Now}.html"));
        }


        [ClassCleanup]
        public void TestClose()
        {

            Console.WriteLine("Completed");

            extentTest.Flush();
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
