﻿using MediatR;
using MyResume.Domain.AppCode.Infracture;
using MyResume.Domain.AppCode.Infrastructure;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyResume.Domain.Business.BlogPostModule
{
    public class BlogPostGetAllQuery : PaginateModel, IRequest<PagedViewModel<BlogPost>>
    {
        public class BlogPostGetAllHandler : IRequestHandler<BlogPostGetAllQuery, PagedViewModel<BlogPost>>
        {
            private readonly MyResumeDbContext db;

            public BlogPostGetAllHandler(MyResumeDbContext db)
            {
                this.db = db;
            }


            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostGetAllQuery request, CancellationToken cancellationToken)
            {
                if (request.PageSize <= 3)
                {
                    request.PageSize = 3;
                }


                int skipSize = (request.PageIndex - 1) * request.PageSize;
                var query =  db.BlogPosts.Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                                             .OrderByDescending(bp => bp.PublishedDate)
                                             .AsQueryable();


                var pagedModel = new PagedViewModel<BlogPost>(query, request);

                return pagedModel;
            }
        }
    }
}
