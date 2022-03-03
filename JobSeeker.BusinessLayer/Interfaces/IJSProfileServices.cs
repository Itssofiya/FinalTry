using JobSeeker.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.BusinessLayer.Interfaces
{
    public interface IJSProfileServices
    {
        
        Task<JSProfile> GetJSById(int Id);
        bool AddJSProfile(JSProfile jSProfile);
        Task<JSProfile> UpdateJSProfile(JSProfile jSProfile);
        Task<JSProfile> DeleteJSProfile(JSProfile jSProfile);
        List<JSProfile> GetProfiles();
    }
}
