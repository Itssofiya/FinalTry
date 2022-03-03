using JobSeeker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.BusinessLayer.Interfaces
{
    public interface IJSCourseServices
    {
       
        Task<JSCourse> GetByJobSeekerId(int JobSeekerId);
        Task<JSCourse> GetByDate(DateTime RequestedDate);
        Task<JSCourse> GetByCourseName(string CourseName);
        Task<JSCourse> DeleteRequestCourse(JSCourse jSCourse);
        Task<JSCourse> UpdateJSCourse(JSCourse jSCourse);
        bool AddJSCourse(JSCourse jSCourse);
        List<JSCourse> GetAllCourses();
    }
}
