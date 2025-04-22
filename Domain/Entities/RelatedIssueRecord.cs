using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class RelatedIssueRecord:AuditableEntity
    {
        public Guid RelatedIssueRecordId { get; set; }
        public Guid RelatedIssueId { get; set; }
        public Guid IssueId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
