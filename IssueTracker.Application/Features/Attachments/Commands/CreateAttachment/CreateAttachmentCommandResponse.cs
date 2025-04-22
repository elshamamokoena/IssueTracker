using IssueTracker.Application.Responses;

namespace IssueTracker.Application.Features.Attachments.Commands.CreateAttachment
{
    public class CreateAttachmentCommandResponse:BaseResponse
    {
        public CreateAttachmentCommandResponse():base() { }
        public CreateAttachmentDto CreateAttachmentDto { get; set; } = default!;
    }
}