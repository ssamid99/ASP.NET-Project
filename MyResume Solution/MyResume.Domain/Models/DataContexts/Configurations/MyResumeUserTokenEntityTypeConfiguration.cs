using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    public class MyResumeUserTokenEntityTypeConfiguration : IEntityTypeConfiguration<MyResumeUserToken>
    {
        public void Configure(EntityTypeBuilder<MyResumeUserToken> builder)
        {
            builder.ToTable("UserTokens","Membership");
        }
    }
}
