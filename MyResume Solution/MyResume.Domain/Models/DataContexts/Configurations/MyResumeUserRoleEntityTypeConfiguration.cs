using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    public class MyResumeUserRoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<MyResumeUserRole>
    {
        public void Configure(EntityTypeBuilder<MyResumeUserRole> builder)
        {
            builder.ToTable("UserRoles","Membership");
        }
    }
}
