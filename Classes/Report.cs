using RPP_Test_Report_Suite.Enums;
using RPP_Test_Report_Suite.Interfaces;

namespace RPP_Test_Report_Suite.Classes
{
    class Report
    {
        public string? ReportName { get; set; }
        public int? ReportVersion { get; set; }
        public string[]? ReportLines { get; set; }
        public DateTime ReportDate { get; set; }
        public int ReportCount { get; set; }
        public bool ReportEnabled { get; set; }
        public string? ReportDescription { get; set; }
        public string? ReportProject { get; set; }
        public int? ReportStyle { get; set; }
        public int? ReportType { get; set; }
        public int? ReportStatus { get; set; }
        public TestCases? TestCases { get; set; }
        public string? AssignedTo { get; set; }
        public string? Author { get; set; }
        public int? TestStage { get; set; }
    }
}
