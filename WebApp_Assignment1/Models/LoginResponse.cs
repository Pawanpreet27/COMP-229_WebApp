using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Assignment1.Models
{
    public class LoginResponse
    {
            [Key]
            public int UResponsesID { get; set; }

         //   [Required(ErrorMessage = "Please enter your Email-ID")]
         //   [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
            public string Username { get; set; }

            [Required(ErrorMessage = "Please enter your Password")]
            //[RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "Please enter a valid Phone Number eg: (xxx) xxx-xxxx")]
            public string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";

    }
    
}
