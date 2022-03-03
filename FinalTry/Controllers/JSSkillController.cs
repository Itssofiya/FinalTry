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
    public class JSSkillController : ControllerBase
    {
        private readonly IJSSkillServices _JSSkillServices;
        public JSSkillController(IJSSkillServices JSSkillServices)
        {
            _JSSkillServices = JSSkillServices;
        }

        [HttpPost]
        [Route("AddJSSkill")]
        public bool AddJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            _JSSkillServices.AddJobSeekerSkill(jobSeekerSkill);
            return true;
        }

        [HttpDelete]
        [Route("DeleteJSSkill")]
        public Task<JobSeekerSkill> DeleteJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            var result = _JSSkillServices.DeleteJobSeekerSkill(jobSeekerSkill);

            return result;
        }

        [HttpGet]
        [Route("GetJSById")]
        public Task<JobSeekerSkill> GetByJobSeekerSkillById(int JobSeekerId)
        {
            var result = _JSSkillServices.GetByJobSeekerSkillById(JobSeekerId);
            return result;
        }

       

        [HttpPut]
        [Route("GetByDate")]
        public Task<JobSeekerSkill> GetJSSkillByDate(DateTime UpdatedDate)
        {
            var result = _JSSkillServices.GetJSSkillByDate(UpdatedDate);
            return result;
        }

        [HttpPut]
        [Route("UpdateJSSkill")]
        public Task<JobSeekerSkill> UpdateJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            var result = _JSSkillServices.UpdateJobSeekerSkill(jobSeekerSkill);
            return result;
        }

        [HttpGet]
        [Route("GetALLSkills")]
        public List<JobSeekerSkill> ShowSkills()
        {
            var result = _JSSkillServices.GetAllSkills();
            return result;
        }

    }
}
