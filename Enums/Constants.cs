namespace RPP_Test_Report_Suite.Enums
{
    public class Constants
    {
        public enum Status
        {
            Running = 0,
            Passed = 1,
            Failed = 2,
            Incomplete = 3,
            Error = 4,
        }
        public enum Stages
        {
            Unit = 0,
            Performance = 1,
            Functionality = 2,
            Regression = 3,
            Integration = 4,
            Acceptance = 5,
            System = 6,
            Pilot = 7,
            Interface = 8
        }
        public enum Severity
        {
            Critical = 1,
            High = 2,
            Medium = 3,
            Low = 4,
            Wish = 5
        }
        public enum ReportType
        {
            HTML = 1,
            Log4Net = 2,
            Logger = 3,
            Database = 4,
            Email = 5,
            Text = 6
        }
        public enum ReportStyles
        {
            Black = 1,
            White = 2,
            Yellow = 3,
            Custom = 4,
            BlackWhite = 5
        }
    }
}