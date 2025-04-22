using IssueTracker.Application.Features.Attachments.Commands.CreateAttachment;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Api.Controllers
{
    [ApiController]
    [Route("api/attachments")]
    public class AttachmentController : ControllerBase
    {
      private readonly IMediator _mediator;

      public AttachmentController(IMediator mediator)
      {
        _mediator = mediator;
      }
      [HttpPost(Name ="CreateAttachment")]
      public async Task<ActionResult<CreateAttachmentCommandResponse>> CreateAttachment([FromBody] CreateAttachmentCommand createAttachmentCommand )
        {
            var response = await _mediator.Send(createAttachmentCommand);
            return Ok(response);
        }

    }
}
