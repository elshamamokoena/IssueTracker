using IssueTracker.Application.Responses;

namespace IssueTracker.Application.Features.Issues.Commands.CreateIssue
{
    public class CreateIssueCommandResponse:BaseResponse
    {
        public CreateIssueCommandResponse() : base() { }
        public CreateIssueDto Issue { get; set; } = default!;
    }
}