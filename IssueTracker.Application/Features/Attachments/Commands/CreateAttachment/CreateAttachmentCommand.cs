using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Attachments.Commands.CreateAttachment
{
    public class CreateAttachmentCommand:IRequest<CreateAttachmentCommandResponse>
    {
        public Guid IssueId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
    }
}
