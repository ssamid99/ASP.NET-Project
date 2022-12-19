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
    internal class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(au => au.Id);
            builder.Property(au => au.Id)
                .UseIdentityColumn(1, 1);
            builder.Property(au => au.Name)
                .IsRequired();
            builder.Property(au => au.Role)
                .IsRequired();
        }
    }
}
