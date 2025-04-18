using IssueTracker.Domain.Models;

namespace IssueTracker.Application.Features.Issues.Commands.CreateIssue
{
    public class CreateIssueDto
    {
        public Guid IssueId { get; set; }
        public string AuthorId { get; set; } = string.Empty;
        public string? OwnerId { get; set; }
        public IssueType? IssueType { get; set; }
        public Severity Severity { get; set; }
        public Priority Priority { get; set; }
        public string? Summary { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}