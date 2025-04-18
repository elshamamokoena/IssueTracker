using IssueTracker.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Commands.UpdateIssue
{
    public class UpdateIssueCommand: IRequest
    {
        public Guid IssueId { get; set; }
        public string AuthorId { get; set; }
        public string? OwnerId { get; set; }
        public IssueType IssueType { get; set;}
        public Severity Severity { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public string? Summary { get; set; }
        public string Description { get; set; }
    }
}
