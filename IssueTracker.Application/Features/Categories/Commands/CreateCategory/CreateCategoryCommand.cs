﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand:IRequest<CreateCategoryCommandResponse>
    {
    }
}
