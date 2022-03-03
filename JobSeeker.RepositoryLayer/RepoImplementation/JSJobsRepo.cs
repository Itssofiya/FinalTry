using JobSeeker.DataLayer;
using JobSeeker.Entities;
using JobSeeker.RepositoryLayer.Intefarces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.RepoImplementation
{
    public class JSJobsRepo : IJSJobsRepo
    {
        private readonly JSDbContext _JobSeekerContext;
        public JSJobsRepo(JSDbContext jSDbContext)
        {
            _JobSeekerContext = jSDbContext;
        }

        public async Task<JSJobs> GetJSJobsByDate(DateTime AppliedDate)
        {
            try
            {
                var result = await _JobSeekerContext.JSJobs
                    .FirstOrDefaultAsync(h => h.AppliedDate.Equals(AppliedDate));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JSJobs> GetJSJobsById(int Id)
        {
            try
            {
                var result = await _JobSeekerContext.JSJobs.FirstOrDefaultAsync(h => h.JobId.Equals(Id));
                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public   Task<JSJobs>GetJSJobsByJobTitle(string JobTitle)
        {
            try
            {
                var result =  _JobSeekerContext.JSJobs.Where(h => h.JobTitle.Equals(JobTitle)).FirstOrDefault();
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
        public List<JSJobs> GetAllJobs()
        {
            var result = _JobSeekerContext.JSJobs.ToList();
            return result;
        }
    }
}
