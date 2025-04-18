using IssueTracker.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Queries.GetIssueList
{
    public class IssueListVm
    {
        public Guid IssueId { get; set; }
        public string AuthorId { get; set; } = string.Empty;
        public string? OwnerId { get; set; }
        public IssueType IssueType { get; set; }
        public Severity Severity { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public string Summary { get; set; } = string.Empty;
    }
}
