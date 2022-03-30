using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TemplatedHtmlHelper.Models
{
    public class Employee
    {
        public int  Id { get; set; }

        [Display(Name="Please Enter Your Name")]

        public string Name { get; set; }

        public string Email { get; set; }

        [Display(Name =" DateOfBirth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }

        public bool IsOnline { get; set; }
    }
}