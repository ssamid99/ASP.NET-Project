using MyResume.Domain.Models.Entities;
using System.Collections.Generic;

namespace MyResume.Domain.Models.ViewModels
{
    public class PortfolioViewModel
    {
        public ICollection<ProjectCategory> ProjectCategories { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
