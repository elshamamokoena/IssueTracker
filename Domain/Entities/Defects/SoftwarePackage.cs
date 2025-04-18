using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities.Defects
{
    public class SoftwarePackage : AuditableEntity
    {
        public Guid SoftwarePackageId { get; set; }
        public Guid SoftwareId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string Maintainer { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<SoftwarePackage> PackageDependencies { get; set; }
            = new List<SoftwarePackage>();
        public ICollection<Bug> AssociatedBugs { get; set; }
            = new List<Bug>();


    }
}
