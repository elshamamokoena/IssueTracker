using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities.Defects
{
    public class SoftwareComponent
    {
        public Guid SoftwareComponentId { get; set; }
        public Guid SoftwareId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<RelatedIssueRecord> RelatedIssues { get; set; }
            = new List<RelatedIssueRecord>();

    }
}
