using IssueTracker.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Commands.CreateIssue
{
    public class CreateIssueCommand:IRequest<CreateIssueCommandResponse>
    {
        public Guid CategoryId { get; set; }    
        public string AuthorId { get; set; } = string.Empty;
        public string? OwnerId { get; set; }
        public IssueType IssueType { get; set; }
        public Severity Severity { get; set; }
        public Priority Priority { get; set; }
        public string? Summary { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
