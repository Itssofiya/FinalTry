using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JSCourseController : ControllerBase
    {
        private readonly IJSCourseServices _JSCourseServices;
        public JSCourseController(IJSCourseServices JSCourseServices)
        {
            _JSCourseServices = JSCourseServices;
        }

        [HttpPost]
        [Route("AddCourse")]
        public bool AddJSCourse(JSCourse jSCourse)
        {
            _JSCourseServices.AddJSCourse(jSCourse);
            return true;
        }

        [HttpDelete]
        [Route("DeleteReqCourse")]
        public Task<JSCourse> DeleteRequestCourse(JSCourse jSCourse)
        {
            var result = _JSCourseServices.DeleteRequestCourse(jSCourse);
            return result;
        }

        [HttpGet]
        [Route("GetByName")]
        public Task<JSCourse> GetByCourseName(string CourseName)
        {
            var result = _JSCourseServices.GetByCourseName(CourseName);
            return result;
        }

        [HttpGet]
        [Route("GetByDate")]
        public Task<JSCourse> GetByDate(DateTime RequestedDate)
        {
            var result = _JSCourseServices.GetByDate(RequestedDate);
            return result;
        }

        [HttpGet]
        [Route("GetById")]
        public Task<JSCourse> GetByJobSeekerId(int JobSeekerId)
        {
            var result = _JSCourseServices.GetByJobSeekerId(JobSeekerId);
            return result;
        }

       
        [HttpPut]
        [Route("UPDATE")]
        public Task<JSCourse> UpdateJSCourse(JSCourse jSCourse)
        {
            var result = _JSCourseServices.UpdateJSCourse(jSCourse);
            return result;
        }

        [HttpGet]
        [Route("GettALLCourse")]
        public List<JSCourse> GetAll()
        {
            var result = _JSCourseServices.GetAllCourses();
            return result;
        }


        
    }
}
