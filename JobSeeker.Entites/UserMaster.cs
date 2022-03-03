using Microsoft.AspNetCore.Identity;
using System;

namespace JobSeeker.Entites
{
    public class UserMaster : IdentityUser
    {
        public string Contact { get; set; }
        public string Address { get; set; }
        public string IdProofNumber { get; set; }
        public bool? Enabled { get; set; }
    }
}
