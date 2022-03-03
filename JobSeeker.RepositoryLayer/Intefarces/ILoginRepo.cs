using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.RepositoryLayer.Interfaces
{
    public interface ILoginRepo
    {
        Task<bool> ValidateUserLogin(string UserName, string Password, string Email);
    }
}
