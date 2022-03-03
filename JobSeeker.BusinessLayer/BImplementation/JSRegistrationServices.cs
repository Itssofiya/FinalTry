using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.Entites;
using JobSeeker.RepositoryLayer.Interfaces;
using JobSeeker.RepositoryLayer.RepoImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace JobSeeker.BusinessLayer.BImplementation
{
    public class JSRegistrationServices : IRegistrationServices
    {
        private readonly IRegistrationRepo _RegistrationRepo;
        public JSRegistrationServices(IRegistrationRepo RegistrationRepo)
        {
            _RegistrationRepo = RegistrationRepo;
        }
        public bool CreateRegistration(JSRegistration jSRegistration)
        {
            _RegistrationRepo.CreateRegistration(jSRegistration);
            return true;
        }

        public bool ValidateUserLogin(string UserName, string Password, string Email)
        {
            _RegistrationRepo.ValidateUserLogin(UserName, Password, Email);
            return true;

        }

    }   
}
