using JobSeeker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.BusinessLayer.Interfaces
{
    public interface IJSJobsServices
    {
     
        Task<JSJobs> GetJSJobsById(int Id);
        Task<JSJobs> GetJSJobsByDate(DateTime AppliedDate);
        Task<JSJobs> GetJSJobsByJobTitle(string JobTitle);
        List<JSJobs> GetAllJobs();
    }
}
public class course
{
    public int Id { get; set; }
    public string cname { get; set; }
    public string jsname { get; set; }

}
