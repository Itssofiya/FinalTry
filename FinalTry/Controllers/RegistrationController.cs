using JobSeeker.BusinessLayer.BImplementation;
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
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationServices _JSRegistrationServices;
        public RegistrationController(IRegistrationServices JSRegistrationServices)
        {
            _JSRegistrationServices = JSRegistrationServices;
        }
        [HttpPost]
        [Route("Reg")]
        public bool Regitration(JSRegistration reg)
        {
            _JSRegistrationServices.CreateRegistration(reg);
            return true;
        }

        [HttpPost]
        [Route("Validate")]
        public bool Validate(string UserName, string Password, string Email)
        {
            var result = _JSRegistrationServices.ValidateUserLogin(UserName, Password, Email);
            return true;
        }

    }
}

public class empl
{
    public string empname { get; set; }
    public int empid { get; set; }
}

