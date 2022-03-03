using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSeeker.Entities
{
    public class JSJobs
    {
		[Key]
		public int Id { get; set; }
		public int JobId { get; set; }
		public int JobSeekerId { get; set; }
		public int AppliedJobs { get; set; }
		public string Jobappliedfor { get; set; }
		public string Status { get; set; }
		public DateTime AppliedDate { get; set; }
		public string Jobtypes { get; set; }
		public string JobTitle { get; set; }
		public string Joblocation { get; set; }
		public string WorkPLace { get; set; }
	}
}
