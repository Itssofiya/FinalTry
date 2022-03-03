using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSeeker.Entites
{
    public class JSProfile
    {
        public int JobSeekerId { get; set; }
        [Key]
        public int ProfileId { get; set; }
        public string JobSeekerName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalExperience { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal RelevantExp { get; set; }

        public int NoticePeriod { get; set; }

        public DateTime AvailableFrom { get; set; }

        public DateTime AvailableTo { get; set; }

        public string CurrentEmployer { get; set; }

        public string CurrentLocation { get; set; }

        public string PrefferdLocation { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostToCompany { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal EmployeerCtC { get; set; }

        public string Skills { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string AddedBy { get; set; }

        public DateTime AddedOn { get; set; }

        public string UpdateBy { get; set; }

    }
}
