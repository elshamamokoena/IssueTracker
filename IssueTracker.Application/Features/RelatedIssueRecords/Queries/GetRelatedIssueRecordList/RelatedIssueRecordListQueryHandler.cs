using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.RelatedIssueRecords.Queries.GetRelatedIssueRecordList
{
    public class RelatedIssueRecordListQueryHandler :
        IRequestHandler<RelatedIssueRecordListQuery, List<RelatedIssueRecordListVm>>
    {
        private readonly IAsyncRepository<Issue> _issueRepositoryRepo;
        private readonly IAsyncRepository<RelatedIssueRecord> _relatedIssueRepo;
        private readonly IMapper _mapper;
        public RelatedIssueRecordListQueryHandler(IAsyncRepository<Issue> repository,
            IAsyncRepository<RelatedIssueRecord> relatedIssue, IMapper mapper)
        {
            _issueRepositoryRepo = repository;
            _relatedIssueRepo = relatedIssue;
            _mapper = mapper;
        }

        public async Task<List<RelatedIssueRecordListVm>> Handle(RelatedIssueRecordListQuery request, CancellationToken cancellationToken)
        {
            if(!await _issueRepositoryRepo.EntityExistsAsync(request.IssueId))
                throw new Exceptions.NotFoundException("Issue",request.IssueId);
            var relatedIssues = (await _relatedIssueRepo.ListAllAsync())
                .Where(x=>x.IssueId == request.IssueId)
                .ToList();
            return _mapper.Map<List<RelatedIssueRecordListVm>>(relatedIssues);
        }
    }
}
