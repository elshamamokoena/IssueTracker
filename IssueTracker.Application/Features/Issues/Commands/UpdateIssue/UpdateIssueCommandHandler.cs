using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Commands.UpdateIssue
{
    public class UpdateIssueCommandHandler : IRequestHandler<UpdateIssueCommand>
    {
        private readonly IAsyncRepository<Issue> _issueRepository;
        private readonly IMapper _mapper;

        public UpdateIssueCommandHandler(IAsyncRepository<Issue> issueRepository, IMapper mapper)
        {
            _issueRepository = issueRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateIssueCommand request, CancellationToken cancellationToken)
        {
            var issueToUpdate = await _issueRepository.GetByIdAsync(request.IssueId);
            _mapper.Map(request, issueToUpdate,typeof(UpdateIssueCommand),typeof(Issue));
            await _issueRepository.UpdateAsync(issueToUpdate);
        }
    }
}
