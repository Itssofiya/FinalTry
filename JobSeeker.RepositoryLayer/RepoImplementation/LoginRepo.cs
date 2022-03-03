using JobSeeker.DataLayer;
using JobSeeker.RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.RepoImplementation
{
    public class LoginRepo : ILoginRepo
    {
        private readonly JSDbContext _JobSeekerContext;


        public LoginRepo(JSDbContext jSDbContext)
        {
            _JobSeekerContext = jSDbContext;
        }
        public Task<bool> ValidateUserLogin(string UserName, string Password, string Email)
        {
            var result = _JobSeekerContext.JSRegistrations.Where(s => s.UserName.Equals(UserName) && s.Password.Equals(Password) || s.Email.Equals(Email) && s.Password.Equals(Password));
            if (result == null)
            {

            }
            return Task.FromResult(true);
        }
    }
}
