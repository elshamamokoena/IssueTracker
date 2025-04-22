using IssueTracker.Application.Responses;

namespace IssueTracker.Application.Features.Issues.RelatedIssueRecords.Commands.CreateRelatedIssueRecord
{
    public class CreateRelatedIssueRecordCommandResponse : BaseResponse
    {
        public CreateRelatedIssueRecordCommandResponse() : base() { }

        public CreateRelatedIssueRecordCommandDto CreateRelatedIssueRecordCommandDto { get; set; } = default!;
    }
}