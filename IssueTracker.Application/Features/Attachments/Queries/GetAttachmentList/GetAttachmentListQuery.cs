using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Attachments.Queries.GetAttachmentList
{
    public class GetAttachmentListQuery:IRequest<List<AttachmentListVm>>
    {
        public Guid IssueId { get; set; }

    }
}
