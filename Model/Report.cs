namespace ErrorReport.Model
{
    public enum SeverityLevel
    {
        Critical,
        Low,
        Medium,
        High
    }
    public enum ReportStatus
    {
        Open,
        Closed,
        Pending
    }

    public class Report
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ReproductionSteps { get; set; }
        public string? ActualBehavior { get; set; }
        public string? ExpectedBehavior { get; set; }
        public string? Frequency { get; set; }
        public string? Attachments {get; set;}
        public string? Logs { get; set; }
        public string? SystemInfo { get; set; }
        public SeverityLevel Severity { get; set; }
        public ReportStatus Status {get; set; }
        public string? Resolution { get; set; }

    }
}
