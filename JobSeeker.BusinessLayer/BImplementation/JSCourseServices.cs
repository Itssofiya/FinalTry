using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.Entities;
using JobSeeker.RepositoryLayer.Intefarces;
using JobSeeker.RepositoryLayer.RepoImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.BusinessLayer.BImplementation
{
    public class JSCourseServices : IJSCourseServices
    {
        private readonly IJSCourseRepo _JSCourseRepository;

        public JSCourseServices(IJSCourseRepo JSCourseRepository)
        {
            _JSCourseRepository = JSCourseRepository;
        }

        public bool AddJSCourse(JSCourse jSCourse)
        {

            _JSCourseRepository.AddJSCourse(jSCourse);
            return true;
        }

        public Task<JSCourse> DeleteRequestCourse(JSCourse jSCourse)
        {
            var result = _JSCourseRepository.DeleteRequestCourse(jSCourse);
            return result;
        }

        public List<JSCourse> GetAllCourses()
        {
            var result = _JSCourseRepository.GetAllCourses();
            return result;
        }

        public Task<JSCourse> GetByCourseName(string CourseName)
        {
            var result = _JSCourseRepository.GetByCourseName(CourseName);
            return result;
        }

        public Task<JSCourse> GetByDate(DateTime RequestedDate)
        {
            var result = _JSCourseRepository.GetByDate(RequestedDate);
            return result;
        }

        public Task<JSCourse> GetByJobSeekerId(int JobSeekerId)
        {
            var result = _JSCourseRepository.GetByJobSeekerId(JobSeekerId);
            return result;
        }


        public Task<JSCourse> UpdateJSCourse(JSCourse jSCourse)
        {
            var result = _JSCourseRepository.UpdateJSCourse(jSCourse);
            return result;
        }
    }
}
