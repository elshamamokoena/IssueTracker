namespace IssueTracker.Application.Features.Attachments.Queries.GetAttachmentList
{
    public class AttachmentListVm
    {
        public Guid AttachmentId { get; set; }
        public Guid IssueId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
    }
}