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
    internal class ResumeExperienceEntityTypeConfiguartion : IEntityTypeConfiguration<ResumeExperience>
    {
        public void Configure(EntityTypeBuilder<ResumeExperience> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.StartYear)
                .IsRequired();
            builder.Property(e => e.Title)
                .IsRequired();
            builder.Property(e => e.CompanyName)
                .IsRequired();
            builder.Property(e => e.Location)
                .IsRequired();
            builder.Property(e => e.Details)
                .IsRequired();
        }
    }
}
