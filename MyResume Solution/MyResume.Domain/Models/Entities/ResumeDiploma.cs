using MyResume.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Models.Entities
{
    public class ResumeDiploma : BaseEntity
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Degree { get; set; }
        public string UniversityName { get; set; }
        public int YearObtention { get; set; }
        public string Details { get; set; }
        public string ImagePath { get; set; }

    }
}
