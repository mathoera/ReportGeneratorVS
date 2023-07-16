using RPP_Test_Report_Suite.Enums;
using RPP_Test_Report_Suite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_Test_Report_Suite.Classes
{
    public class TestStep
    {
        public int? StepID { get; set; }
        public string? StepName { get; set; }
        public string? StepDescription { get; set; }
        public int? Severity { get; set; }
        public string? ExpectedResult { get; set; }
        public string? ActualResult { get; set; }
        public int? Status { get; set; }
        public DateTime? LogTime { get; set; }
    }
}
