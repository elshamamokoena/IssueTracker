using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Commands.CreateIssue
{
    public class CreateIssueCommandValidator:AbstractValidator<CreateIssueCommand>
    {
        public CreateIssueCommandValidator()
        {
            RuleFor(i => i.AuthorId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull().WithMessage("{PropertyName} is required.");

            RuleFor(i => i.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(1000).WithMessage("{PropertyName} has exceeded the maximum number of characters(1000).");
        }
    }
}
