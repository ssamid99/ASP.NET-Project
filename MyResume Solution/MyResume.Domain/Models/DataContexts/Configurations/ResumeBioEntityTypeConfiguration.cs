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
    internal class ResumeBioEntityTypeConfiguration : IEntityTypeConfiguration<ResumeBio>
    {
        public void Configure(EntityTypeBuilder<ResumeBio> builder)
        {
            builder.HasKey(b => b.Id);
                
            builder.Property(b=>b.Text)
                .IsRequired();
        }
    }
}
