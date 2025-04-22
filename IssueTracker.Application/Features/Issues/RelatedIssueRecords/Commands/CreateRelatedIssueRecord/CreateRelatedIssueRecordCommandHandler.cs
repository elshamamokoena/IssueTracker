using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.RelatedIssueRecords.Commands.CreateRelatedIssueRecord
{
    public class CreateRelatedIssueRecordCommandHandler :
        IRequestHandler<CreateRelatedIssueRecordCommand, CreateRelatedIssueRecordCommandResponse>
    {
        private readonly IAsyncRepository<Issue> _issueRepository;
        private readonly IAsyncRepository<RelatedIssueRecord> _relatedIssueRepository;
        private readonly IMapper _mapper;
        public CreateRelatedIssueRecordCommandHandler(IAsyncRepository<Issue> issueRepository,
            IMapper mapper, IAsyncRepository<RelatedIssueRecord> relatedIssueRepository)
        {
            _issueRepository = issueRepository;
            _mapper = mapper;
            _relatedIssueRepository = relatedIssueRepository;
        }


        public async Task<CreateRelatedIssueRecordCommandResponse> Handle(CreateRelatedIssueRecordCommand request, CancellationToken cancellationToken)
        {
            if (!await _issueRepository.EntityExistsAsync(request.IssueId))
                throw new Exceptions.NotFoundException("Issue", request.IssueId);

            if (!await _issueRepository.EntityExistsAsync(request.RelatedIssueId))
                throw new Exceptions.NotFoundException("Related issue", request.IssueId);

            var response = new CreateRelatedIssueRecordCommandResponse();
            var validator = new CreateRelatedIssueRecordCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            if(response.Success)
            {
                var issueToCreate = _mapper.Map<RelatedIssueRecord>(request);
                var issueToReturn = await _relatedIssueRepository.AddAsync(issueToCreate);
                response.CreateRelatedIssueRecordCommandDto = _mapper.Map<CreateRelatedIssueRecordCommandDto>(issueToReturn);
            }

            return response;
        }
    }
}
