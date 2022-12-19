using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    public class MyResumeUserClaimClaimEntityTypeConfiguration : IEntityTypeConfiguration<MyResumeUserClaim>
    {
        public void Configure(EntityTypeBuilder<MyResumeUserClaim> builder)
        {
            builder.ToTable("UserClaims","Membership");
        }
    }
}
