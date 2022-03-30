using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class ReturnBookModel
    {
        public int id { get; set; }
        public Nullable<int> mid { get; set; }
        public string book { get; set; }
        public Nullable<System.DateTime> returndate { get; set; }
        public Nullable<int> elap { get; set; }
        public Nullable<int> fine { get; set; }
    }
}