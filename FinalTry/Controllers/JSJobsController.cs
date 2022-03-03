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
    public class JSJobsController : ControllerBase
    {
        private readonly IJSJobsServices _JSJobsServices;
        public JSJobsController(IJSJobsServices JSJobsServices)
        {
            _JSJobsServices = JSJobsServices;
        }

       

        [HttpGet]
        [Route("GetJobByTitle")]
        public Task<JSJobs> GetJSJobsByJobTitle(string JobTitle)
        {
            var result = _JSJobsServices.GetJSJobsByJobTitle(JobTitle);
            return result;
        }

        [HttpGet]
        [Route("GetJobById")]
        public Task<JSJobs> GetJSJobsById(int Id)
        {
            var result = _JSJobsServices.GetJSJobsById(Id);
            return result;
        }

        [HttpGet]
        [Route("GetJobByDate")]
        public Task<JSJobs> GetJSJobsByDate(DateTime AppliedDate)
        {
            var result = _JSJobsServices.GetJSJobsByDate(AppliedDate);
            return result;
        }

        [HttpGet]
        [Route("AllJobs")]
        public List<JSJobs> ShowListofJobs()
        {
            var result = _JSJobsServices.GetAllJobs();
            return result;
        }

    }
}
