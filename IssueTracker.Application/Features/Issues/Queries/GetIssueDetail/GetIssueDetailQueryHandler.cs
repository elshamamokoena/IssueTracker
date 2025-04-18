using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Queries.GetIssueDetail
{
    public class GetIssueDetailQueryHandler : IRequestHandler<GetIssueDetailQuery, IssueVm>
    {
        private readonly IAsyncRepository<Issue> _issueRepository;
        private readonly IMapper _mapper;
        public GetIssueDetailQueryHandler(IAsyncRepository<Issue> issueRepository, IMapper mapper)
        {
            _issueRepository = issueRepository;
            _mapper = mapper;
        }

        public async Task<IssueVm> Handle(GetIssueDetailQuery request, CancellationToken cancellationToken)
        {
            var issue = await _issueRepository.GetByIdAsync(request.IssueId);
            var issueDetailDto = _mapper.Map<IssueVm>(issue);
            return issueDetailDto;
        }
    }
}
