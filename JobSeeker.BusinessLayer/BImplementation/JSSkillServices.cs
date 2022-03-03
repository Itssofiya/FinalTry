using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.Entities;
using JobSeeker.RepositoryLayer.Interfaces;
using JobSeeker.RepositoryLayer.RepoImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.BusinessLayer.BImplementation
{
    public class JSSkillServices : IJSSkillServices
    {
        private readonly IJSSkillRepo _JSSkillRepository;

        public JSSkillServices(IJSSkillRepo JSSkillRepository)
        {
            _JSSkillRepository = JSSkillRepository;
        }
        public bool AddJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            _JSSkillRepository.AddJobSeekerSkill(jobSeekerSkill);
            return true;
        }

        public Task<JobSeekerSkill> DeleteJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            var result = _JSSkillRepository.DeleteJobSeekerSkill(jobSeekerSkill);

            return result;
        }

        public Task<JobSeekerSkill> GetByJobSeekerSkillById(int JobSeekerId)
        {
            var result = _JSSkillRepository.GetByJobSeekerSkillById(JobSeekerId);
            return result;
        }

       

        public Task<JobSeekerSkill> GetJSSkillByDate(DateTime UpdatedDate)
        {
            var result = _JSSkillRepository.GetJSSkillByDate(UpdatedDate);
            return result;
        }

        public Task<JobSeekerSkill> UpdateJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            var result = _JSSkillRepository.UpdateJobSeekerSkill(jobSeekerSkill);
            return result;
        }
        public List<JobSeekerSkill> GetAllSkills()
        {
            var result = _JSSkillRepository.GetAllSkill();
            return result;
        }
    }
}
