using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.RelatedIssueRecords.Commands.CreateRelatedIssueRecord
{
    public class CreateRelatedIssueRecordCommandValidator:AbstractValidator<CreateRelatedIssueRecordCommand>
    {
        public CreateRelatedIssueRecordCommandValidator() 
        {
            RuleFor(i=>i.IssueId)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(i => i.RelatedIssueId)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(i => i.Description)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");

        }
    }
}
