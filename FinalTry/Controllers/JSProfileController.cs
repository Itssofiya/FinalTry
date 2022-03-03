using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.Entites;
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
    public class JSProfileController : ControllerBase
    {
        private readonly IJSProfileServices _JSProfileServices;
        public JSProfileController(IJSProfileServices JSProfileServices)
        {
            _JSProfileServices = JSProfileServices;
        }

        [HttpPost]
        public bool AddJSProfile(JSProfile jSProfile)
        {
            var result = _JSProfileServices.AddJSProfile(jSProfile);
            return true;
        }
        [HttpDelete]
        [Route("DeleteProfile")]
        public Task<JSProfile> DeleteJSProfile(JSProfile jSProfile)
        {
            var result = _JSProfileServices.DeleteJSProfile(jSProfile);
            return result;
        }

        [HttpGet]
        [Route("GetById")]
        public Task<JSProfile> GetJSById(int Id)
        {
            var result = _JSProfileServices.GetJSById(Id);
            return result;
        }


        [HttpPut]
        [Route("UpdateProfile")]
        public Task<JSProfile> UpdateJSProfile(JSProfile jSProfile)
        {
            var result = _JSProfileServices.UpdateJSProfile(jSProfile);
            return result;
        }

        [HttpGet]
        [Route("GetProfile")]
        public List<JSProfile> GetProfiles()
        {
            var result = _JSProfileServices.GetProfiles();
            return result;
        }
    }
}
