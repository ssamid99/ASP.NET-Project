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
    internal class ResumeDiplomaEntityTypeConfiguartion : IEntityTypeConfiguration<ResumeDiploma>
    {
        public void Configure(EntityTypeBuilder<ResumeDiploma> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.StartYear)
                .IsRequired();
            builder.Property(d => d.Degree)
                .IsRequired();
            builder.Property(d => d.UniversityName)
                .IsRequired();
        }
    }
}
