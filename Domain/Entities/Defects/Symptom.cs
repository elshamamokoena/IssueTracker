using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities.Defects
{
    public class Symptom : AuditableEntity
    {
        public Guid SymptomId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Keyword { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
