using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.RepositoryLayer.Interfaces;
using JobSeeker.RepositoryLayer.RepoImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobSeeker.BusinessLayer.BImplementation
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginRepo _LoginRepo;
        public LoginServices(ILoginRepo loginRepo)
        {
            _LoginRepo = loginRepo;
        }
        public bool ValidateUserLogin(string UserName, string Password, string Email)
        {
            throw new NotImplementedException();
        }
    }
}
