using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    public class MyResumeRoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<MyResumeRoleClaim>
    {
        public void Configure(EntityTypeBuilder<MyResumeRoleClaim> builder)
        {
            builder.ToTable("RoleClaims","Membership");
        }
    }
}
