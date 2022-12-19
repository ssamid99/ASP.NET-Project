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
    internal class AboutEntityTypeConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .IsRequired();
            builder.Property(a => a.Age)
                .IsRequired();
            builder.Property(a => a.Location)
                .IsRequired();
            builder.Property(a => a.Experience)
                .IsRequired();
            builder.Property(a => a.Phone)
                .IsRequired();
            builder.Property(a => a.Email)
                .IsRequired();
            builder.Property(a => a.ShortDescription)
                .IsRequired();
        }
    }
}
