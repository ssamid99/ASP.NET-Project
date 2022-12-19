﻿using MyResume.Domain.Business.BlogPostModule;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyResume.Domain.Business.BlogPostModule
{
    public class BlogPostCommentRemoveCommand : IRequest<BlogPostComment>
    {
        public int Id { get; set; }
        public class BlogPostCommentRemoveCommandHandler : IRequestHandler<BlogPostCommentRemoveCommand, BlogPostComment>
        {
            private readonly MyResumeDbContext db;

            public BlogPostCommentRemoveCommandHandler(MyResumeDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPostComment> Handle(BlogPostCommentRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = db.BlogPostComments.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);

                if (data == null)
                {
                    return null;
                }
                data.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}

