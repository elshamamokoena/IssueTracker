using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Models
{
    public enum IssueType
    {
        Defect,
        FeatureRequest,
        Task,
        Incident,
        Enhancements,
        TechnicalDebt,
        Documentation,
        GeneralSuggestions
    }
}
