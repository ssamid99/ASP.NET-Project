using MyResume.Domain.AppCode.Infrastructure;

namespace MyResume.Domain.Models.Entities
{
    public  class Project : BaseEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Link { get; set; }

        public int ProjectCategoryId { get; set; }

        public virtual ProjectCategory ProjectCategory { get; set; }
    }
}
