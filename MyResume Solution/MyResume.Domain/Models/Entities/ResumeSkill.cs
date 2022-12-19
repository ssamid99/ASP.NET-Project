﻿using MyResume.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Models.Entities
{
    public class ResumeSkill : BaseEntity
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public DateTime? SelectedDate { get; set; }
        public string View { get; set; }
        public int ResumeCategoryId { get; set; }
        public virtual ResumeCategory ResumeCategory { get; set; }
    }
}
