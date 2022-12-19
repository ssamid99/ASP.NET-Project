using MyResume.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Models.Entities
{
    public class About : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Location { get; set; }

        public int Experience { get; set; }

        public string Degree { get; set; }
        public string CareerLevel { get; set; }

        public string Phone { get; set; }
        public string Fax { get; set; }

        public string Email { get; set; }
        public string Website { get; set; }

        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
