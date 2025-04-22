using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class AffectedPlatform : AuditableEntity
    {
        public Guid AffectedPlatformId { get; set; }
        public Guid IssuePlatformId { get; set; }
        public Guid IssueId { get; set; }
        public Guid PlatformId { get; set; }
    }
}
