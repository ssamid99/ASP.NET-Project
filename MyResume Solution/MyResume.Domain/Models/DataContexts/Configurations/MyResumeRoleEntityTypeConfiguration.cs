using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    public class MyResumeRoleEntityTypeConfiguration : IEntityTypeConfiguration<MyResumeRole>
    {
        public void Configure(EntityTypeBuilder<MyResumeRole> builder)
        {
            builder.ToTable("Roles","Membership");
        }
    }
}
