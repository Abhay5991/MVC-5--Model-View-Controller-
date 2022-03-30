using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraditionalRouting.Models
{
    public class Students
    {
        public int Id { get; set; }

        public  string Name { get; set; }

        public string Class { get; set; }

        public Address Address { get; set; }
    }
}