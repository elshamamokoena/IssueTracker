using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Commands.DeleteIssue
{
    public class DeleteIssueCommand:IRequest
    {
        public Guid IssueId { get; set; } 
    }
}
