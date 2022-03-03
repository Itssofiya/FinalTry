using JobSeeker.DataLayer;
using JobSeeker.Entites;
using JobSeeker.RepositoryLayer.Intefarces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.RepoImplementation
{
    public class JSProfileRepo : IJSProfileRepo
    {
        private readonly JSDbContext _JobSeekerContext;
        public JSProfileRepo(JSDbContext jSDbContext)
        {
            _JobSeekerContext = jSDbContext;
        }

        public async Task<bool> AddJSProfile(JSProfile jSProfile)
        {
            try
            {
                await _JobSeekerContext.JSProfiles.AddAsync(jSProfile);
                await _JobSeekerContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JSProfile> DeleteJSProfile(JSProfile jSProfile)
        {
            try
            {
                _JobSeekerContext.JSProfiles.Remove(jSProfile);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jSProfile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async  Task<JSProfile> GetJSById(int Id)
        {
            try
            {
                var result = await _JobSeekerContext.JSProfiles.FirstOrDefaultAsync(h => h.JobSeekerId.Equals(Id));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JSProfile> UpdateJSProfile(JSProfile jSProfile)
        {
            try
            {
                _JobSeekerContext.JSProfiles.Update(jSProfile);
                await _JobSeekerContext.SaveChangesAsync();
                return await Task.FromResult(jSProfile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public List<JSProfile> GetAllProfiles()
        {
            var result = _JobSeekerContext.JSProfiles.ToList();
            return result;
        }
    }
}
