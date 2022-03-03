﻿using JobSeeker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.Interfaces
{
    public interface IJSSessionRepo
    {
       
        Task<JobSeekerSession> GetByName(JobSeekerSession jobSeekerSession);
        Task<JobSeekerSession> GetRequestedSessionByDate(DateTime requestedSessionDate);
        Task<JobSeekerSession> GetMissedSessionByDate(DateTime MissedSessionDate);
        Task<JobSeekerSession> GetAttendedSessionByDate(DateTime AttendedSessionDate);
        Task<JobSeekerSession> GetRequestedSessionById(int RequestedSessionId);
        Task<JobSeekerSession> GetMissedSessionById(int MissedSessionId);
        Task<JobSeekerSession> GetAttendedSessionById(int AttendedSessionId);
        Task<JobSeekerSession> GetByStatus(string Status);
        Task<bool> AddJobSeekerSession(JobSeekerSession jobSeekerSession);
        Task<JobSeekerSession> UpdateJobSeekerSession(JobSeekerSession jobSeekerSession);
        Task<JobSeekerSession> DeleteJobSeekerSession(JobSeekerSession jobSeekerSession);
        List<JobSeekerSession> GetAllSessions();
    }
}
