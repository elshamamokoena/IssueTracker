using AutoMapper;
using IssueTracker.Application.Features.Issues.Commands.CreateIssue;
using IssueTracker.Application.Features.Issues.Queries.GetIssueDetail;
using IssueTracker.Application.Features.Issues.Queries.GetIssueList;
using IssueTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Issue, CreateIssueCommand>().ReverseMap();
            CreateMap<Issue, CreateIssueDto>().ReverseMap();
            CreateMap<Issue, IssueVm>().ReverseMap();
            CreateMap<Issue, IssueListVm>();
        }
    }
}
