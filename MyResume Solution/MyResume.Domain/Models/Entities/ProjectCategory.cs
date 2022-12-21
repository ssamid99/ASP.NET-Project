using MyResume.Domain.AppCode.Infrastructure;
using System.Collections.Generic;

namespace MyResume.Domain.Models.Entities
{
    public class ProjectCategory : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
