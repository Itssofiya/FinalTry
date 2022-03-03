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
    public class JSSessionController : ControllerBase
    {
        private readonly IJSSessionServices _JSSessionServices;
        public JSSessionController(IJSSessionServices JSSessionServices)
        {
            _JSSessionServices = JSSessionServices;
        }

        [HttpPost]
        [Route("AddSession")]
        public bool AddJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            _JSSessionServices.AddJobSeekerSession(jobSeekerSession);
            return true;
        }
        [HttpDelete]
        [Route("DeleteSession")]
        public Task<JobSeekerSession> DeleteJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            var result = _JSSessionServices.DeleteJobSeekerSession(jobSeekerSession);
            return result;
        }
        [HttpGet]
        [Route("GetByAttendedDate")]
        public Task<JobSeekerSession> GetAttendedSessionByDate(DateTime AttendedSessionDate)
        {
            var result = _JSSessionServices.GetAttendedSessionByDate(AttendedSessionDate);
            return result;
        }

        [HttpGet]
        [Route("GetBAttendedyId")]
        public Task<JobSeekerSession> GetAttendedSessionById(int AttendedSessionId)
        {
            var result = _JSSessionServices.GetAttendedSessionById(AttendedSessionId);
            return result;

        }

        [HttpGet]
        [Route("GetByMissedDate")]
        public Task<JobSeekerSession> GetMissedSessionByDate(DateTime MissedSessionDate)
        {
            var result = _JSSessionServices.GetAttendedSessionByDate(MissedSessionDate);
            return result;
        }

        [HttpGet]
        [Route("GetByMissedId")]

        public Task<JobSeekerSession> GetMissedSessionById(int MissedSessionId)
        {
            var result = _JSSessionServices.GetMissedSessionById(MissedSessionId);
            return result;
        }

        [HttpGet]
        [Route("GetBySeeionName")]

        public Task<JobSeekerSession> GetByName(JobSeekerSession jobSeekerSession)
        {
            var result = _JSSessionServices.GetByName(jobSeekerSession);
            return result;
        }

        [HttpGet]
        [Route("api/GetByReqDtae")]
        public Task<JobSeekerSession> GetRequestedSessionByDate(DateTime requestedSessionDate)
        {
            var result = _JSSessionServices.GetRequestedSessionByDate(requestedSessionDate);
            return result;
        }

        [HttpGet]
        [Route("GetByReqId")]
        public Task<JobSeekerSession> GetRequestedSessionById(int RequestedSessionId)
        {
            var result = _JSSessionServices.GetRequestedSessionById(RequestedSessionId);
            return result;
        }


        [HttpGet]
        [Route("GetByStatus")]
        public Task<JobSeekerSession> GetByStatus(string Status)
        {
            var result = _JSSessionServices.GetByStatus(Status);
            return result;
        }


       
        [HttpGet]
        [Route("UpadteSession")]
        public Task<JobSeekerSession> UpdateJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            var result = _JSSessionServices.UpdateJobSeekerSession(jobSeekerSession);
            return result;
        }

        [HttpGet]
        [Route("ALLsessions")]
        public List<JobSeekerSession>GetAllSessions()
        {
           var result= _JSSessionServices.GetAllSessions();
            return result;
                 

        }
    }
}



