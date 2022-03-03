using JobSeeker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.Intefarces
{
    public interface IJSJobsRepo
    {
       
        Task<JSJobs> GetJSJobsById(int Id);
        Task<JSJobs> GetJSJobsByDate(DateTime AppliedDate);
        Task<JSJobs> GetJSJobsByJobTitle(string JobTitle);
        List<JSJobs> GetAllJobs();
    }
}
