using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Attachments.Commands.CreateAttachment
{
    public class CreateAttachmentCommandValidator:AbstractValidator<CreateAttachmentCommand>
    {
        public CreateAttachmentCommandValidator() { 
        
            RuleFor(a=>a.IssueId)
                .NotNull()
                .NotEmpty().WithMessage("Issue Id is required.");
            RuleFor(b => b.Name)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(c => c.IssueId)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
