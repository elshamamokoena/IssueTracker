using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class IssueSymptomRecord : AuditableEntity
    {
        public Guid IssueSymptomRecordId { get; set; }
        public Guid IssueId { get; set; }
        public Guid SymptomId { get; set; }
    }
}
