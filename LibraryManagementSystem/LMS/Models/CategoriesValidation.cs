using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{

    [MetadataType(typeof(categoryMetadata))]
    public  partial class Category
    {
       
        public class categoryMetadata
        {
            [DisplayName("Category Name")]

            public string CatName { get; set; }

            [DisplayName("Status")]

            public string Status { get; set; }
        }
    }
}