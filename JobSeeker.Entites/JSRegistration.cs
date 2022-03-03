using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSeeker.Entites
{
   public  class JSRegistration
    {
        [Key]
        public int RID { get; set; }
        [Required(ErrorMessage = "UserId is Required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Field Cannot Be Empty")]
        public string Password { get; set; }
        public long Mobile { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
