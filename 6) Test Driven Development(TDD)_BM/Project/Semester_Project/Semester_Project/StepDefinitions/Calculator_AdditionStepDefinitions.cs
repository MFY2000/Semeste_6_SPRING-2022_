using System;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Semester_Project.Support.Test_case_Model;
using TechTalk.SpecFlow.Assist;

namespace Semester_Project.StepDefinitions
{

    [Binding]
    public class Calculator_AdditionStepDefinitions
    {
        ExtentReports extentTest = null;
        IEnumerable <Calculator_param> testData = null;
        ExtentTest singleTestReport = null;

        [BeforeScenario]
        public void TestInitialize()
        {

            Console.WriteLine("start");

            extentTest = new ExtentReports();
            extentTest.AttachReporter(new ExtentHtmlReporter(@"C:/Users/DarkJoker/Desktop/Semeste_6_FALL-2021_/6) Test Driven Development(TDD)_BM/ProjectSemester_Project/Semester_Project/Reports/Addition_{DateTime.Now}.html"));
        }


        [AfterScenario]
        public void TestClose() {
            
            Console.WriteLine("Completed");
            
            extentTest.Flush();
        }



        [Given(@"Open the windowApp")]
        public void GivenOpenTheWindowApp()
        {

        }

        [When(@"Fill all data in given model to test it")]
        public void WhenFillAllDataInGivenModelToTestIt(Table table)
        {
            testData =  table.CreateSet<Calculator_param>();
        }

        [Then(@"Start testing on the given input throught model class reference\.")]
        public void ThenStartTestingOnTheGivenInputThroughtModelClassReference_()
        {
            
            
            Console.WriteLine(testData.ToString());
            foreach (Calculator_param param in testData)
            {
                singleTestReport = extentTest.CreateTest($"Addition Test {param.sno}").Info(param.Error_Message);
                singleTestReport.Log(Status.Info, "Testing start");
                
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
