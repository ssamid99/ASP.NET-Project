using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyResume.Domain.Models.Entities.Membership
{
    public class MyResumeUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public ICollection<BlogPostComment> BlogPostComments { get; set; }
    }
}
