using RPP_Test_Report_Suite.Enums;
using RPP_Test_Report_Suite.Interfaces;

namespace RPP_Test_Report_Suite.Classes
{
    class TestCases
    {
        public int TestCaseNumber { get; set; }
        public string TestCaseName { get; set; } = string.Empty;
        public string? TestCaseDescription { get; set; }
        public int? TestCaseType { get; set; }
        public string? TestStatus { get; set; }
        public DateTime TestStartTime { get; set; }
        public DateTime TestEndTime { get; set; }
        public int TestCaseCount { get; set; }
        public int TestRetestCount { get; set; }
        public TestStep? TestStep { get; set; }
        public string? RiskScore { get; set; }
        public int? TestResult { get; set; }
        public string? ConfigurationItem { get; set; }
        public string? ExpectedValues { get; set; }
        public string? ActualValues { get; set; }
        public string? TestGroup { get; set; }
        public string? AssignedTo { get; set; }
        public string? CreatedBy { get; set; }
        public string? ReviewedBy { get; set; }
        public int? Version { get; set; }
        public string? PreConditions { get; set; }
        public string? PostConditions { get; set; }
        public int? IncidentNumber { get; set;}
        public IList<IRequirements>? Requirements { get; set; }
    }
}
