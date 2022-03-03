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
    public class JSSessionServices : IJSSessionServices
    {
        private readonly IJSSessionRepo _JSSessionRepository;

        public JSSessionServices(IJSSessionRepo JSSessionRepository)
        {
            _JSSessionRepository = JSSessionRepository;
        }

        public bool AddJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            _JSSessionRepository.AddJobSeekerSession(jobSeekerSession);
            return true;
        }

        public Task<JobSeekerSession> DeleteJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            var result = _JSSessionRepository.DeleteJobSeekerSession(jobSeekerSession);
            return result;
        }

        public Task<JobSeekerSession> GetAttendedSessionByDate(DateTime AttendedSessionDate)
        {
            var result = _JSSessionRepository.GetAttendedSessionByDate(AttendedSessionDate);
            return result;
        }

        public Task<JobSeekerSession> GetAttendedSessionById(int AttendedSessionId)
        {
            var result =_JSSessionRepository.GetAttendedSessionById(AttendedSessionId);
            return result;
                 
        }

        public Task<JobSeekerSession> GetMissedSessionByDate(DateTime MissedSessionDate)
        {
            var result = _JSSessionRepository.GetAttendedSessionByDate(MissedSessionDate);
            return result;
        }

        public Task<JobSeekerSession> GetMissedSessionById(int MissedSessionId)
        {
            var result = _JSSessionRepository.GetMissedSessionById(MissedSessionId);
            return result;
        }

        public Task<JobSeekerSession> GetByName(JobSeekerSession jobSeekerSession)
        {
            var result = _JSSessionRepository.GetByName(jobSeekerSession);
            return result;
        }

        public Task<JobSeekerSession> GetRequestedSessionByDate(DateTime requestedSessionDate)
        {
            var result = _JSSessionRepository.GetRequestedSessionByDate(requestedSessionDate);
            return result;
        }

        public Task<JobSeekerSession> GetRequestedSessionById(int RequestedSessionId)
        {
            var result = _JSSessionRepository.GetRequestedSessionById(RequestedSessionId);
            return result;
        }

        public Task<JobSeekerSession> GetByStatus(string Status)
        {
            var result = _JSSessionRepository.GetByStatus(Status);
            return result;
        }

       

        public Task<JobSeekerSession> UpdateJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            var result = _JSSessionRepository.UpdateJobSeekerSession(jobSeekerSession);
            return result;
        }
        public List<JobSeekerSession> GetAllSessions()
        {
            var result = _JSSessionRepository.GetAllSessions();
            return result;
        }
    }
}
