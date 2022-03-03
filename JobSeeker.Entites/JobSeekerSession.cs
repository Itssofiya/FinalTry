using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSeeker.Entities
{
    public class JobSeekerSession
    {
        [Key]
        public int Id { get; set; }
        public int sessionid { get; set; }
        public int MentorId { get; set; }
        public int JobseekerId { get; set; }
        public string JobSeekerName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int RequestedSessionId { get; set; }
        public DateTime RequestedSessionDate { get; set; }
        public string RequestedSessionCourse { get; set; }
        public int Missedsessionid { get; set; }
        public DateTime MissedSessionDate { get; set; }
        public string MissedSessionCourse { get; set; }
        public string MissedReason { get; set; }
        public int Attendedsessisonid { get; set; }
        public string AttendedCourse { get; set; }
        public DateTime AttendedSessionDate { get; set; }
        public double PaidAmount { get; set; }
        public DateTime Sessionstart { get; set; }
        public DateTime Sessionend { get; set; }
        public string Status { get; set; }
    }
}

//public class course
//{
//    public int Id { get; set; }
//    public string cname { get; set; }
//    public string jsname { get; set; }

//}
//public course getbyname();
//{
//    var result = course.where(c => c.cname.euals(c.name).select());
//    return result;
//}