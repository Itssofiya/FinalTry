using JobSeeker.DataLayer;
using JobSeeker.Entities;
using JobSeeker.RepositoryLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.RepoImplementation
{
    public class JSSkillRepo : IJSSkillRepo
    {
        private readonly JSDbContext _JobSeekerContext;
        public JSSkillRepo(JSDbContext jSDbContext)
        {
            _JobSeekerContext = jSDbContext;
        }
        public async  Task<bool> AddJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            try
            {
                await _JobSeekerContext.JobSeekerSkills.AddAsync(jobSeekerSkill);
                await _JobSeekerContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSkill> DeleteJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            try
            {
                _JobSeekerContext.JobSeekerSkills.Remove(jobSeekerSkill);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jobSeekerSkill);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSkill> GetByJobSeekerSkillById(int JobSeekerId)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSkills.FirstOrDefaultAsync(h => h.JobSeekerId.Equals(JobSeekerId));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

        public async Task<JobSeekerSkill> GetJSSkillByDate(DateTime UpdatedDate)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSkills
                    .FirstOrDefaultAsync(h => h.UpdeatedDate.Equals(UpdatedDate));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSkill> UpdateJobSeekerSkill(JobSeekerSkill jobSeekerSkill)
        {
            try
            {
                _JobSeekerContext.JobSeekerSkills.Update(jobSeekerSkill);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jobSeekerSkill);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

        public List<JobSeekerSkill> GetAllSkill()
        {
            {
                var result = _JobSeekerContext.JobSeekerSkills.ToList();
                return result;
            }
        }
    }

       
    
}
