using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationMVC.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }

        [AbhayValidationMVC]
        public string  Message { get; set; }
    }
}