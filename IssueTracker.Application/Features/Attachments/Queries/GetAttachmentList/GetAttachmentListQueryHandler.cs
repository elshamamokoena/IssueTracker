using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Attachments.Queries.GetAttachmentList
{
    public class GetAttachmentListQueryHandler : IRequestHandler<GetAttachmentListQuery, List<AttachmentListVm>>
    {
        private readonly IAsyncRepository<Attachment> _attachmentRepository;
        private readonly IAsyncRepository<Issue> _issueRepository;
        private readonly IMapper _mapper;
        public GetAttachmentListQueryHandler(IAsyncRepository<Attachment> attachmentRepository,
            IAsyncRepository<Issue> issueRepository, IMapper mapper)
        {
            _attachmentRepository = attachmentRepository;
            _issueRepository = issueRepository;
            _mapper = mapper;
        }

        public async Task<List<AttachmentListVm>> Handle(GetAttachmentListQuery request, CancellationToken cancellationToken)
        {
            if(!await _issueRepository.EntityExistsAsync(request.IssueId)) 
                throw new Exceptions.NotFoundException("Issue",request.IssueId);
            var attachments = (await _attachmentRepository.ListAllAsync())
                .Where(a => a.IssueId == request.IssueId)
                .OrderByDescending(a => a.Created);
            return _mapper.Map<List<AttachmentListVm>>(attachments);
        }
    }
}
