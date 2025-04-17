using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class BugPlatform:AuditableEntity
    {
        public Guid BugPlatformId { get; set; }
        public Guid BugId { get; set; }
        public Guid PlatformId { get; set; }
    }
}
