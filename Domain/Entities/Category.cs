﻿using IssueTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class Category:AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Issue> Issues { get; set; } = new List<Issue>();

    }
}
