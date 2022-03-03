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
    public class JSSessionRepo : IJSSessionRepo
    {
        private readonly JSDbContext _JobSeekerContext;
        public JSSessionRepo(JSDbContext jSDbContext)
        {
            _JobSeekerContext = jSDbContext;
        }

        public async Task<bool> AddJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            try
            {
                await _JobSeekerContext.JobSeekerSessions.AddAsync(jobSeekerSession);
                await _JobSeekerContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSession> DeleteJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            try
            {
                _JobSeekerContext.JobSeekerSessions.Remove(jobSeekerSession);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jobSeekerSession);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSession> GetAttendedSessionByDate(DateTime AttendedSessionDate)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions
                 .FirstOrDefaultAsync(h => h.AttendedSessionDate.Equals(AttendedSessionDate));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSession> GetAttendedSessionById(int AttendedSessionId)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions.FirstOrDefaultAsync(h => h.Attendedsessisonid.Equals(AttendedSessionId));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async  Task<JobSeekerSession> GetMissedSessionByDate(DateTime MissedSessionDate)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions
                 .FirstOrDefaultAsync(h => h.AttendedSessionDate.Equals(MissedSessionDate));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSession> GetMissedSessionById(int MissedSessionId)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions.FirstOrDefaultAsync(h => h.Missedsessionid.Equals(MissedSessionId));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSession> GetByName(JobSeekerSession jobSeekerSession)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions.FirstOrDefaultAsync(h => h.JobSeekerName.Equals(jobSeekerSession));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSession> GetRequestedSessionByDate(DateTime requestedSessionDate)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions
                 .FirstOrDefaultAsync(h => h.RequestedSessionDate.Equals(requestedSessionDate));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
    }

        public async Task<JobSeekerSession> GetRequestedSessionById(int RequestedSessionId)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions.FirstOrDefaultAsync(h => h.RequestedSessionId.Equals(RequestedSessionId));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JobSeekerSession> GetByStatus(string Status)
        {
            try
            {
                var result = await _JobSeekerContext.JobSeekerSessions.FirstOrDefaultAsync(h => h.Status.Equals(Status));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       

        public async  Task<JobSeekerSession> UpdateJobSeekerSession(JobSeekerSession jobSeekerSession)
        {
            try
            {
                _JobSeekerContext.JobSeekerSessions.Update(jobSeekerSession);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jobSeekerSession);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<JobSeekerSession> GetAllSessions()
        {
            var result = _JobSeekerContext.JobSeekerSessions.ToList();
            return result;
        }
    }
}
