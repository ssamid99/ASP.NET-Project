using MediatR;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyResume.Domain.Business.ProjectsModule
{
    public class ProjectGetAllQuery : IRequest<List<Project>>
    {
        public int ProjectCategoryId { get; set; }

        public class ProjectGetAllQueryHandler : IRequestHandler<ProjectGetAllQuery, List<Project>>
        {
            private readonly MyResumeDbContext db;

            public ProjectGetAllQueryHandler(MyResumeDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Project>> Handle(ProjectGetAllQuery request, CancellationToken cancellationToken)
            {
                
                var data = await db.Projects
                .Include(p => p.ProjectCategory)
                .Where(p => p.DeletedDate == null)
                .OrderByDescending(p=>p.ProjectCategory)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
