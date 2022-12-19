using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContexts.Configurations
{
    public class MyResumeUserLoginEntityTypeConfiguration : IEntityTypeConfiguration<MyResumeUserLogin>
    {
        public void Configure(EntityTypeBuilder<MyResumeUserLogin> builder)
        {
            builder.ToTable("UserLogins","Membership");
        }
    }
}
