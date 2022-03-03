using System;
using System.Collections.Generic;
using System.Text;

namespace JobSeeker.BusinessLayer.Interfaces
{
    public interface ILoginServices
    {
        bool ValidateUserLogin(string UserName, string Password, string Email);
    }
}
