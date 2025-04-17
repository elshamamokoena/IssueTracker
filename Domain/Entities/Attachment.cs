using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class Attachment:AuditableEntity
    {
        public Guid AttachmentId { get; set; }
        public Guid BugId { get; set; }
        public string ? AuthorId { get; set; }
    }
}
