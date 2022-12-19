using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Models.Entities;
using MyResume.Domain.Models.Entities.Membership;
using MyResume.Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Models.DataContexts
{
    public class MyResumeDbContext : IdentityDbContext<MyResumeUser, MyResumeRole, int, MyResumeUserClaim, MyResumeUserRole, MyResumeUserLogin, MyResumeRoleClaim, MyResumeUserToken>
    {
        public MyResumeDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostComment> BlogPostComments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ResumeBio> ResumeBios { get; set; }
        public DbSet<ResumeCategory> ResumeCategorys { get; set; }
        public DbSet<ResumeSkill> ResumeSkills { get; set; }
        public DbSet<ResumeExperience> ResumeExperiences { get; set; }
        public DbSet<ResumeDiploma> ResumeDiplomas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var asm = typeof(MyResumeDbContext).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(asm);
        }
    }
}
