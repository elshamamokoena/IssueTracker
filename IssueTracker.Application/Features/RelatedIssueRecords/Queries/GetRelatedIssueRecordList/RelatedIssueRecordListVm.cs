namespace IssueTracker.Application.Features.RelatedIssueRecords.Queries.GetRelatedIssueRecordList
{
    public class RelatedIssueRecordListVm
    {
        public Guid RelatedIssueRecordId { get; set; }
        public Guid RelatedIssueId { get; set; }
        public Guid IssueId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}