namespace IssueTracker.Application.Features.Categories.Queries.GetCategoryList
{
    public class GetCategoryListVm
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}