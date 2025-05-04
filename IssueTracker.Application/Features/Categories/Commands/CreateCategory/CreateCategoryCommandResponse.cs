using IssueTracker.Application.Responses;

namespace IssueTracker.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse:BaseResponse
    {
        public CreateCategoryCommandResponse():base() { }
        public CreateCategoryCommandDto CreateCategoryCommandDto { get; set; } = default!;
    }
}