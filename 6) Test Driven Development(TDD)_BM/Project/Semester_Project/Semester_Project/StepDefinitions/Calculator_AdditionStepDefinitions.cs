using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Calculator_Testing.Support;
using Semester_Project.Support.Test_case_Model;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Calculator_Testing.StepDefinitions
{
    [Binding]
    public class Calculator_AdditionStepDefinitions : LoadDriver
    {
        ExtentReports extentTest = null;
        IEnumerable<Calculator_param> testData = null;
        ExtentTest singleTestReport = null;


        [BeforeScenario]
        public void TestInitialize()
        {

            InitializeDriver();
            extentTest = new ExtentReports();
            string address = $"C:/Users/DarkJoker/Desktop/Reports/Addition/";
            var report = new ExtentHtmlReporter(@address);
            extentTest.AttachReporter(report);
        }


        [AfterScenario]
        public void TestClose()
        {
            //extentTest.Flush();
        }



        [Given(@"Open the windowApp")]
        public void GivenOpenTheWindowApp()
        {

        }

        [When(@"Fill all data in given model to test it")]
        public void WhenFillAllDataInGivenModelToTestIt(Table table)
        {
            testData = table.CreateSet<Calculator_param>();
        }

        [Then(@"Start testing on the given input throught model class reference\.")]
        public void ThenStartTestingOnTheGivenInputThroughtModelClassReference_()
        {


            Console.WriteLine(testData.ToString());
            foreach (Calculator_param param in testData)
            {
                singleTestReport = extentTest.CreateTest($"Addition Test {param.sno}").Info(param.Error_Message);
                singleTestReport.Log(Status.Info, "Testing start");

                driver.FindElementByName("1").Click();
                driver.FindElementByName("4").Click();
                driver.FindElementByName("+").Click();
                driver.FindElementByName("4").Click();
                driver.FindElementByName("=").Click();
                driver.Close();



                if (param.Expected_output == 4)
                {
                    singleTestReport.Log(Status.Pass, $"Addition Test {param.sno} Passed");
                }
                else
                {
                    singleTestReport.Log(Status.Fail, $"Addition Test {param.sno} Failed");
                }
            }
        }

        [Then(@"The result should match the Expected_output of the table")]
        public void ThenTheResultShouldMatchTheExpected_OutputOfTheTable()
        {
            Console.WriteLine("hello");

        }

        [When(@"All test case are complete report them on the log\.")]
        public void WhenAllTestCaseAreCompleteReportThemOnTheLog_()
        {
            Console.WriteLine("hello");

        }
    }
}
