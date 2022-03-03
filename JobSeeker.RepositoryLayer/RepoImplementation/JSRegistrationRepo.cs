using JobSeeker.DataLayer;
using JobSeeker.Entites;
using JobSeeker.RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.RepoImplementation
{
    public class JSRegistrationRepo : IRegistrationRepo
    {
        private readonly JSDbContext _JobSeekerContext;


        public JSRegistrationRepo(JSDbContext jSDbContext)
        {
            _JobSeekerContext = jSDbContext;
        }

        public async Task<bool> CreateRegistration(JSRegistration jSRegistration)
        {
            try
            {
                await _JobSeekerContext.JSRegistrations.AddAsync(jSRegistration);
                await _JobSeekerContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidateUserLogin(string UserName, string Password, string Email)
        {
            {
                var result = _JobSeekerContext.JSRegistrations.Where(s => s.UserName.Equals(UserName) && s.Password.Equals(Password) || s.Email.Equals(Email) && s.Password.Equals(Password)).FirstOrDefault();
                if (UserName == null && Password == null || Email == null && Password == null)
                {
                    return false;
                }
                return true;
            }
        }
    }
}

