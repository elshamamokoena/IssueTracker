using AutoMapper;
using IssueTracker.Application.Contracts.Persistence;
using IssueTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Attachments.Commands.CreateAttachment
{
    public class CreateAttachmentCommandHandler : IRequestHandler<CreateAttachmentCommand, CreateAttachmentCommandResponse>
    {
        private readonly IAsyncRepository<Attachment> _attachmentRepository;
        private readonly IAsyncRepository<Issue> _issueRepository;
        private readonly IMapper _mapper;
        public CreateAttachmentCommandHandler(IAsyncRepository<Attachment> attachmentRepository,
            IAsyncRepository<Issue> issueRepository, IMapper mapper)
        {
            _attachmentRepository = attachmentRepository;
            _issueRepository = issueRepository;
            _mapper = mapper;
        }

        public async Task<CreateAttachmentCommandResponse> Handle(CreateAttachmentCommand request, CancellationToken cancellationToken)
        {
            if (!await _issueRepository.EntityExistsAsync(request.IssueId))
                throw new Exceptions.NotFoundException($"Issue", request.IssueId);
            
            var response = new CreateAttachmentCommandResponse();
            var validator = new CreateAttachmentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors) 
                {
                     response.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (response.Success)
            {
                var attachmentToCreate = _mapper.Map<Attachment>(request);
                var attachmentToReturn = await _attachmentRepository.AddAsync(attachmentToCreate);
                response.CreateAttachmentDto = _mapper.Map<CreateAttachmentDto>(attachmentToReturn);
            }
            return response;
        }
    }
}
