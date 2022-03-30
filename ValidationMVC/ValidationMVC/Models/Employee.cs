using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationMVC.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter Your First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Age")]
        [Range(18,100)]
        public int  Age { get; set; }
    }
}