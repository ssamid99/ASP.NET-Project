using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    public class MyResumeUserEntityTypeConfiguration : IEntityTypeConfiguration<MyResumeUser>
    {
        public void Configure(EntityTypeBuilder<MyResumeUser> builder)
        {
            builder.ToTable("Users","Membership");

            builder.Property(u => u.Name)
                .IsRequired();
            builder.Property(u => u.Surname)
                .IsRequired();
        }
    }
}
