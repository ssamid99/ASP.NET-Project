using MediatR;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyResume.Domain.Business.ProjectCategoryModule
{
    public class ProjectCategoryGetSingleQuery : IRequest<ProjectCategory>
    {
        public int Id { get; set; }
        public class ProjectCategorySingleQueryHandler : IRequestHandler<ProjectCategoryGetSingleQuery, ProjectCategory>
        {
            private readonly MyResumeDbContext db;

            public ProjectCategorySingleQueryHandler(MyResumeDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories.FirstOrDefaultAsync(p=>p.Id == request.Id);
                    
                return data;
            }
        }

    }
}
