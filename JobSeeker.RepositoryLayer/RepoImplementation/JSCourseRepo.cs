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
    public class JSCourseRepo : IJSCourseRepo
    {
        private readonly JSDbContext _JobSeekerContext;
        public JSCourseRepo(JSDbContext jSDbContext)
        {
            _JobSeekerContext = jSDbContext;
        }

        public async Task<bool> AddJSCourse(JSCourse jSCourse)
        {
            try
            {
                await _JobSeekerContext.JSCourses.AddAsync(jSCourse);
                await _JobSeekerContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async  Task<JSCourse> DeleteRequestCourse(JSCourse jSCourse)
        {
            try
            {
               var result =  _JobSeekerContext.JSCourses.Remove(jSCourse);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jSCourse);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
        }

        public List<JSCourse> GetAllCourses()
        {
            var result = _JobSeekerContext.JSCourses.ToList();
            return result;
        }

        public async  Task<JSCourse> GetByCourseName(string CourseName)
        {
            try
            {
                var result = await _JobSeekerContext.JSCourses.FirstOrDefaultAsync(h => h.CourseName.Equals(CourseName));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async  Task<JSCourse> GetByDate(DateTime RequestedDate)
        {
            try
            {
                var result = await _JobSeekerContext.JSCourses
                 .FirstOrDefaultAsync(h => h.RequestedDate.Equals(RequestedDate));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<JSCourse> GetByJobSeekerId(int JobSeekerId)
        {
            try
            {
                var result = await _JobSeekerContext.JSCourses.FirstOrDefaultAsync(h => h.JobSeekerId.Equals(JobSeekerId));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        public async  Task<JSCourse> UpdateJSCourse(JSCourse jSCourse)
        {
            try
            {
                _JobSeekerContext.JSCourses.Update(jSCourse);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jSCourse);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
