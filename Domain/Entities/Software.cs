using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class Software
    {
        public Guid SoftwareId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string Description { get; set;} = string.Empty;
        public ICollection<Software> SoftwareDependencies { get; set; } 
            = new List<Software>();
        public ICollection<SoftwarePackage> Packages { get; set; } 
            = new List<SoftwarePackage>();
        public ICollection< SoftwareComponent>  SoftwareComponent { get; set; } 
            = new List<SoftwareComponent>();
        public ICollection<Bug> AssociatedBugs { get; set; } = new List<Bug>();
      

    }
}
