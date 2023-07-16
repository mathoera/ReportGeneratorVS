using RPP_Test_Report_Suite.Classes;
using RPP_Test_Report_Suite.Enums;

namespace RPP_Test_Report_Suite
{
    public class Reporter
    {
        public void CreateTestReportType1()
        {
            Report report = new()
            {
                ReportProject = "",
                ReportName = "Test",
                //report.ReportLines[0] = "Test",
                ReportStyle = (int?)Constants.ReportStyles.Yellow,
                Author = "Test",
                ReportStatus = (int?)Constants.Status.Passed,
                ReportDate = DateTime.Now,
                ReportType = (int?)Constants.ReportType.Log4Net,
                AssignedTo = "Test",
                ReportVersion = 1,
                ReportDescription = "Test",
                TestStage = (int?)Constants.Stages.Regression,
                TestCases = TestCase()
            };
            Console.WriteLine(report);
        }
        private TestCases TestCase()
        {
            TestCases testCases = new()
            {
                PreConditions = "Test",
                Version = 1,
                TestCaseName = "Test",
                TestCaseDescription = "Test",
                TestCaseType = (int?)Constants.Stages.Regression,
                TestStatus = "",
                TestStartTime = DateTime.Now,
                TestEndTime = DateTime.Now,
                TestResult = (int?)Constants.Status.Passed,
                TestGroup = "Test",
                ExpectedValues = "Test",
                ActualValues = "",
                TestStep = TestStep(),
                PostConditions = "Test"
            };

            return testCases;
        }

        private TestStep TestStep()
        {
            TestStep testSteps = new()
            {
                Severity = (int?)Constants.Severity.High,
                Status = (int?)Constants.Status.Passed,
                StepID = 1,
                StepName = "Test",
                StepDescription = "Test",
                ActualResult = "Test",
                ExpectedResult = "Test",
                LogTime = DateTime.Now
            };

            return testSteps;
        }
    }
}
