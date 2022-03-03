using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSeeker.Entities
{
   public  class JSCourse
    {
		[Key]
		public int Id { get; set; }
		public int CourseId { get; set; }
		public int MentorId { get; set; }
		public int JobSeekerId { get; set; }
		public string JobSeekerName { get; set; }
		public string CourseName { get; set; }
		public DateTime RequestedDate { get; set; }
	}
}
