using JobSeeker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.BusinessLayer.Interfaces
{
    public interface IJSSkillServices
    {
       
        Task<JobSeekerSkill> GetJSSkillByDate(DateTime UpdatedDate);
        Task<JobSeekerSkill> GetByJobSeekerSkillById(int JobSeekerId);
        bool AddJobSeekerSkill(JobSeekerSkill jobSeekerSkill);
        Task<JobSeekerSkill> UpdateJobSeekerSkill(JobSeekerSkill jobSeekerSkill);
        Task<JobSeekerSkill> DeleteJobSeekerSkill(JobSeekerSkill jobSeekerSkill);
        List<JobSeekerSkill> GetAllSkills();
    }
}
