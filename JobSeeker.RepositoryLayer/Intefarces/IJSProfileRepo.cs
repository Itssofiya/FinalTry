using JobSeeker.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.Intefarces
{
    public interface IJSProfileRepo
    {
      
        Task<JSProfile> GetJSById(int Id);
        Task<bool> AddJSProfile(JSProfile jSProfile);
        Task<JSProfile> UpdateJSProfile(JSProfile jSProfile);
        Task<JSProfile> DeleteJSProfile(JSProfile jSProfile);
        List<JSProfile> GetAllProfiles();
        
    }
}
