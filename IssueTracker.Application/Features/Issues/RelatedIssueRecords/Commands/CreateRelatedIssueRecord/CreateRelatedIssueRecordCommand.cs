using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.RelatedIssueRecords.Commands.CreateRelatedIssueRecord
{
    public class CreateRelatedIssueRecordCommand : IRequest<CreateRelatedIssueRecordCommandResponse>
    {
        public Guid IssueId { get; set; }
        public Guid RelatedIssueId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
