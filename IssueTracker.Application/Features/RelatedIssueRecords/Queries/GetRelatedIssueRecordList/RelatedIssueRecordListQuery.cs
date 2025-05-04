using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.RelatedIssueRecords.Queries.GetRelatedIssueRecordList
{
    public class RelatedIssueRecordListQuery:IRequest<List<RelatedIssueRecordListVm>>
    {
        public Guid IssueId { get; set; }
    }
}
