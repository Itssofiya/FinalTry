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
    public class JSJobsServices : IJSJobsServices
    {
        private readonly IJSJobsRepo _JSJobsRepository;

        public JSJobsServices(IJSJobsRepo JSJobsRepository)
        {
            _JSJobsRepository = JSJobsRepository;
        }

        public Task<JSJobs> GetJSJobsByDate(DateTime AppliedDate)
        {
            var result = _JSJobsRepository.GetJSJobsByDate(AppliedDate);
            return result;
        }

        public Task<JSJobs> GetJSJobsById(int Id)
        {
            var result = _JSJobsRepository.GetJSJobsById(Id);
            return result;
        }

        public Task<JSJobs> GetJSJobsByJobTitle(string JobTitle)
        {
            var result = _JSJobsRepository.GetJSJobsByJobTitle(JobTitle);
            return result;
        }
       

      

        public List<JSJobs> GetAllJobs()
        {
            var result = _JSJobsRepository.GetAllJobs();
            return result;
        }
    }
}
