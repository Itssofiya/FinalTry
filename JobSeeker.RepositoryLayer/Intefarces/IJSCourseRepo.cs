using JobSeeker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.Intefarces
{
    public interface IJSCourseRepo
    {
       
        Task<JSCourse> GetByJobSeekerId(int JobSeekerId);
        Task<JSCourse> GetByDate(DateTime RequestedDate);
        Task<JSCourse> GetByCourseName(string CourseName);
        Task<JSCourse> DeleteRequestCourse(JSCourse jSCourse);
        Task<JSCourse> UpdateJSCourse(JSCourse jSCourse);
        Task<bool> AddJSCourse(JSCourse jSCourse);
        List<JSCourse> GetAllCourses();
    }
}
