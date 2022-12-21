using MediatR;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MyResume.Domain.Business.ProjectCategoryModule
{
    public class ProjectCategoryCreateCommand : IRequest<ProjectCategory> 
    {
        public string Name { get; set; }
        public class ProjectCategoryCreateCommandHandler : IRequestHandler<ProjectCategoryCreateCommand, ProjectCategory>
        {
            private readonly MyResumeDbContext db;

            public ProjectCategoryCreateCommandHandler(MyResumeDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryCreateCommand request, CancellationToken cancellationToken)
            {
                var model = new ProjectCategory();

                model.Name = request.Name;

                await db.ProjectCategories.AddAsync(model, cancellationToken);

                await db.SaveChangesAsync(cancellationToken);

                return model;
            }


        }
    }
}
