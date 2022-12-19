using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Models.Entities.Membership;

namespace MyResume.Domain.Models.DataContents
{
    public partial class MyResumeDbContext
    {
        public DbSet<MyResumeRole> Roles { get; set; }
        public DbSet<MyResumeRoleClaim> RoleClaims { get; set; }
        public DbSet<MyResumeUser> Users { get; set; }
        public DbSet<MyResumeUserClaim> UserClaims { get; set; }
        public DbSet<MyResumeUserLogin> UserLogins { get; set; }
        public DbSet<MyResumeUserRole> UserRoles { get; set; }
        public DbSet<MyResumeUserToken> UserTokens { get; set; }
    }
}
