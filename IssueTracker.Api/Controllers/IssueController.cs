using IssueTracker.Application.Features.Issues.Commands.CreateIssue;
using IssueTracker.Application.Features.Issues.Commands.DeleteIssue;
using IssueTracker.Application.Features.Issues.Commands.UpdateIssue;
using IssueTracker.Application.Features.Issues.Queries.GetIssueList;
using IssueTracker.Application.Features.Issues.RelatedIssueRecords.Commands.CreateRelatedIssueRecord;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Api.Controllers
{
    [Route("api/issues")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IMediator _mediator;
        public IssueController(IMediator mediator) { 
            _mediator = mediator;
        }

        [HttpGet("all", Name ="GetAllIssues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<IssueListVm>>> GetAllIssues()
        {
            var dtos = await _mediator.Send(new GetIssueListQuery());
            return dtos;
        }

        [HttpPost(Name ="AddIssue")]
        public async Task<ActionResult<CreateIssueCommandResponse>> CreateIssue([FromBody] CreateIssueCommand createIssueCommand)
        {
            var response = await _mediator.Send(createIssueCommand);
            return Ok(response);
        }

        [HttpPut(Name ="UpdateIssue")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateIssue([FromBody] UpdateIssueCommand updateIssueCommand)
        {
            await _mediator.Send(updateIssueCommand);
            return NoContent();
        }

        [HttpDelete("{id}",Name ="DeleteIssue")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteIssue(Guid id)
        {
            await _mediator.Send(new DeleteIssueCommand { IssueId = id });
            return NoContent();
        }
        [HttpPost("relatedissue",Name ="CreateRelatedIssue")]
        public async Task<ActionResult<CreateRelatedIssueRecordCommandResponse>> 
            CreateRelatedIssue(CreateRelatedIssueRecordCommand createRelatedIssueRecordCommand)
        {
            var response = await _mediator.Send(createRelatedIssueRecordCommand);
            return Ok(response);
        }
    }
}
