using IssueTracker.Domain.Common;
using IssueTracker.Domain.Entities.Defects;
using IssueTracker.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class Issue:AuditableEntity
    {
        public Guid IssueId { get; set; }
        public string AuthorId { get; set; } = string.Empty;
        public string? OwnerId { get; set; }
        public DateTime? Resolved { get; set; }
        public IssueType IssueType { get; set; }
        public Severity Severity { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public string Summary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        //Related software details; if any
        public Guid? SoftwareId { get; set; }
        public Guid? SoftwareComponentId { get; set; }
        public Guid? SoftwarePackageId { get; set; }

        public ICollection<Attachment> Attachments { get; set; }
                          = new List<Attachment>();
        public ICollection<IssueSymptomRecord> IssueSymptomRecords { get; set; }
         = new List<IssueSymptomRecord>();
        public ICollection<AffectedPlatform> IssueAffectedPlatforms { get; set; }
                            = new List<AffectedPlatform>();
        public ICollection<Issue> RelatedIssues { get; set; }
           = new List<Issue>();
    }
}
