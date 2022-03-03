using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.Entites;
using JobSeeker.RepositoryLayer.Intefarces;
using JobSeeker.RepositoryLayer.RepoImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.BusinessLayer.BImplementation
{
    public class JSProfileServices : IJSProfileServices
    {
        private readonly IJSProfileRepo _JSProfileRepository;

        public JSProfileServices(IJSProfileRepo JSProfileRepository)
        {
            _JSProfileRepository = JSProfileRepository;
        }
        public bool AddJSProfile(JSProfile jSProfile)
        {
            var result = _JSProfileRepository.AddJSProfile(jSProfile);
            return true;
        }

        public Task<JSProfile> DeleteJSProfile(JSProfile jSProfile)
        {
            var result = _JSProfileRepository.DeleteJSProfile(jSProfile);
            return result;
        }

        public Task<JSProfile> GetJSById(int Id)
        {
            var result = _JSProfileRepository.GetJSById(Id);
            return result;
        }

        

        public Task<JSProfile> UpdateJSProfile(JSProfile jSProfile)
        {
            var result = _JSProfileRepository.UpdateJSProfile(jSProfile);
            return result;
        }
        public List<JSProfile> GetProfiles()
        {
            var result = _JSProfileRepository.GetAllProfiles();
            return result;       
        }
    }
}
