using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class Attachment : AuditableEntity
    {
        public Guid AttachmentId { get; set; }
        public Guid IssueId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
    }
}
