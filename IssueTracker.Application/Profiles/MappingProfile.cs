using AutoMapper;
using IssueTracker.Application.Features.Attachments.Commands.CreateAttachment;
using IssueTracker.Application.Features.Attachments.Queries.GetAttachmentList;
using IssueTracker.Application.Features.Categories.Queries.GetCategoryList;
using IssueTracker.Application.Features.Issues.Commands.CreateIssue;
using IssueTracker.Application.Features.Issues.Commands.UpdateIssue;
using IssueTracker.Application.Features.Issues.Queries.GetIssueDetail;
using IssueTracker.Application.Features.Issues.Queries.GetIssueList;
using IssueTracker.Application.Features.RelatedIssueRecords.Commands.CreateRelatedIssueRecord;
using IssueTracker.Application.Features.RelatedIssueRecords.Queries.GetRelatedIssueRecordList;
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
            CreateMap<UpdateIssueCommand, Issue>();

            //Attachments
            CreateMap<CreateAttachmentCommand, Attachment>();
            CreateMap<Attachment, CreateAttachmentDto>();
            CreateMap<Attachment, AttachmentListVm>();


            //related issues
            CreateMap<RelatedIssueRecord, CreateRelatedIssueRecordCommandDto>();
            CreateMap<CreateRelatedIssueRecordCommand, RelatedIssueRecord>();
            CreateMap<RelatedIssueRecordListVm, RelatedIssueRecord>();
            //Categories
            CreateMap<Category, GetCategoryListVm>();
        }
    }
}
