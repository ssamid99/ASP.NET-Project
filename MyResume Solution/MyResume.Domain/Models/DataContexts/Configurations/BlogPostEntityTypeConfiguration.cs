using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    internal class BlogPostEntityTypeConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasKey(bp => bp.Id);
            builder.Property(bp => bp.Title)
                .IsRequired();
            builder.Property(bp => bp.Body)
                .IsRequired();
            builder.Property(bp => bp.ImagePath)
                .IsRequired();
            builder.Property(bp => bp.Slug)
                .IsUnicode(false)
                .HasMaxLength(900)
                .IsRequired();
            builder.HasIndex(bp=>bp.Slug)
                .IsUnique();
        }
    }
}
