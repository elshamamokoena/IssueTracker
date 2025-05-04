using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Commands.CreateIssue
{
    public class CreateIssueCommandHandler : IRequestHandler<CreateIssueCommand, CreateIssueCommandResponse>
    {

        private readonly IAsyncRepository<Issue> _issueRepository;
        private readonly IMapper _mapper;

        public CreateIssueCommandHandler(IAsyncRepository<Issue> issueRepository, IMapper mapper)
        {
            _issueRepository = issueRepository;
            _mapper = mapper;
        }

        public async Task<CreateIssueCommandResponse> Handle(CreateIssueCommand request, CancellationToken cancellationToken)
        {
            var createIssueCommandResponse = new CreateIssueCommandResponse();
            var validator = new CreateIssueCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createIssueCommandResponse.Success = false;
                createIssueCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createIssueCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if(createIssueCommandResponse.Success)
            {
                var issue = _mapper.Map<Issue>(request);
                issue = await _issueRepository.AddAsync(issue);
                createIssueCommandResponse.Issue = _mapper.Map<CreateIssueDto>(issue);
            }
            return createIssueCommandResponse;
        }
    }
}
