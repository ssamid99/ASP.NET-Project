using MediatR;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyResume.Domain.Business.BlogPostModule
{
    public class BlogPostGetSingleQuery : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public class BlogPostGetSingleQueryHandler : IRequestHandler<BlogPostGetSingleQuery, BlogPost>
        {
            private readonly MyResumeDbContext db;

            public BlogPostGetSingleQueryHandler(MyResumeDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostGetSingleQuery request, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts
                    .Include(bp => bp.Comments.Where(BP=>BP.DeletedDate ==null))
                    .ThenInclude(bp => bp.CreatedByUser)

                       .Include(bp => bp.Comments.Where(BP => BP.DeletedDate == null))
                       .ThenInclude(bp => bp.Parent)

                       .Include(bp => bp.Comments.Where(BP => BP.DeletedDate == null))
                       .ThenInclude(bp => bp.Children.Where(BP => BP.DeletedDate == null))
                    .AsQueryable();
                if (string.IsNullOrWhiteSpace(request.Slug))
                {
                    return await query.FirstOrDefaultAsync(bp => bp.Id == request.Id, cancellationToken);

                }
                return await query.FirstOrDefaultAsync(bp => bp.Slug.Equals(request.Slug), cancellationToken);
            }
        }
    }
}
