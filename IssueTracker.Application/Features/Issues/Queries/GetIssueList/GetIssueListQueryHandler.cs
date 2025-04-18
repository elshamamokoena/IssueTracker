using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Queries.GetIssueList
{
    public class GetIssueListQueryHandler : IRequestHandler<GetIssueListQuery, List<IssueListVm>>
    {
        private readonly IAsyncRepository<Issue> _asyncRepository;
        private readonly IMapper _mapper;

        public GetIssueListQueryHandler(IAsyncRepository<Issue> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        public async Task<List<IssueListVm>> Handle(GetIssueListQuery request, CancellationToken cancellationToken)
        {
            var allIssues = (await _asyncRepository.ListAllAsync())
                .OrderByDescending(x => x.Created);
            return _mapper.Map<List<IssueListVm>>(allIssues);
        }
    }
}
