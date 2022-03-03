using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSeeker.Entities
{
    public class JobSeekerSkill
    {
        [Key]
        public int SId { get; set; }
        public int SkillId { get; set; }
        public int JobSeekerId { get; set; }
        public string Qualification { get; set; }
        public string SkillAreas { get; set; }
        public string SkillExperience { get; set; }
        public DateTime UpdeatedDate { get; set; }
        public long ExpectedSalary { get; set; }
        public string PreferdLocation { get; set; }
    }

    
}