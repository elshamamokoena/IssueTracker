using IssueTracker.Domain.Common;
using IssueTracker.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class Bug : AuditableEntity
    {
        public Guid BugId { get; set; }
        public Guid SoftwareId { get; set; }
        public Guid SoftwareComponentId { get; set; }
        public Guid SoftwarePackageId { get; set; }
        public string? AuthorId { get; set; }
        public string? OwnerId { get; set; }
        public DateTime? Resolved { get; set; }
        public Severity Severity { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public ICollection<BugSymptom> BugSymptoms { get; set; }
            = new List<BugSymptom>();
        public ICollection<BugPlatform> BugPlatforms { get; set; } 
            = new List<BugPlatform>();
        public ICollection<Attachment> Attachments { get; set; }
            = new List<Attachment>();
        public ICollection<Bug> AssociatedBugs { get; set; }
            = new List<Bug>();
    }
}
