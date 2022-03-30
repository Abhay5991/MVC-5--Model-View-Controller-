using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    [MetadataType(typeof(AuthorMetaData))]
    public partial class Author
    {

        public class AuthorMetaData
        {
            [DisplayName("Author Name")]
            public string AuthorName { get; set; }

            [DisplayName("Author Address")]
            public string AutAddress { get; set; }

            [DisplayName("Author Phone")]
            public string AutPhone { get; set; }
        }
    }
}