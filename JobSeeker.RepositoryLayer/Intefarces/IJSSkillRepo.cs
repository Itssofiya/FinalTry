using JobSeeker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.Interfaces
{
    public interface IJSSkillRepo
    {
       
        Task<JobSeekerSkill> GetJSSkillByDate(DateTime UpdatedDate);
        Task<JobSeekerSkill> GetByJobSeekerSkillById(int JobSeekerId);
        Task<bool> AddJobSeekerSkill(JobSeekerSkill jobSeekerSkill);
        Task<JobSeekerSkill> UpdateJobSeekerSkill(JobSeekerSkill jobSeekerSkill);
        Task<JobSeekerSkill> DeleteJobSeekerSkill(JobSeekerSkill jobSeekerSkill);
        List<JobSeekerSkill> GetAllSkill();
    }
}

