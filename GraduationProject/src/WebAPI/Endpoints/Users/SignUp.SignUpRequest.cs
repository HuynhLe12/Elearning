using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Users
{
    public class SignUpRequest
    {

        [Required]
        public string UserName { set; get; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Please input again the same password")]
        public string ConfirmPassword { get; set; }



    }
}
