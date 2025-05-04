namespace IssueTracker.Application.Features.RelatedIssueRecords.Commands.CreateRelatedIssueRecord
{
    public class CreateRelatedIssueRecordCommandDto
    {
        public Guid RelatedIssueRecordId { get; set; }
        public Guid RelatedIssueId { get; set; }
        public Guid IssueId { get; set; }
        public string Description { get; set; } = string.Empty;

    }
}