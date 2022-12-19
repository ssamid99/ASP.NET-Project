using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    internal class ResumeCategoryEntityTypeConfiguartion : IEntityTypeConfiguration<ResumeCategory>
    {
        public void Configure(EntityTypeBuilder<ResumeCategory> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name)
                .IsRequired();
        }
    }
}
