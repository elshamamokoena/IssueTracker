﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Issues.Queries.GetIssueDetail
{
    public class GetIssueDetailQuery:IRequest<IssueVm>
    {
        public Guid IssueId { get; set; }
    }
}
