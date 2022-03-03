using JobSeeker.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobSeeker.BusinessLayer.Interfaces
{
    public interface IRegistrationServices
    {
        bool CreateRegistration(JSRegistration jSRegistration);
        bool ValidateUserLogin(string UserName, string Password, string Email);
    }
}
