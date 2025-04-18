using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Commands.DeleteIssue
{
    public class DeleteIssueCommandHandler : IRequestHandler<DeleteIssueCommand>
    {
        private readonly IAsyncRepository<Issue> _issueRepository;
        public DeleteIssueCommandHandler(IAsyncRepository<Issue> issueRepository) {
            _issueRepository = issueRepository;
        }
        public async Task Handle(DeleteIssueCommand request, CancellationToken cancellationToken)
        {
            var issueToDelete = await _issueRepository.GetByIdAsync(request.IssueId);

            await _issueRepository.DeleteAsync(issueToDelete);
        }
    }
}
