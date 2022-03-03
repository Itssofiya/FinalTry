using JobSeeker.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.Interfaces
{
    public interface IRegistrationRepo
    {
        Task<bool> CreateRegistration(JSRegistration jSRegistration);
        bool ValidateUserLogin(string UserName, string Password, string Email);
        
        


    }
}
