using MyResume.Domain.AppCode.Infrastructure;
using MyResume.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Models.ViewModels
{
   public class BlogPostSingleViewModel
   {
        public BlogPost Post { get; set; }
        //public List<BlogPostComment> Comments { get; set; }
    }
}
