using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    [MetadataType(typeof(MemberMetaData))]
    public partial class Member
    {
        
        public class MemberMetaData
        {
            [DisplayName("Member Name")]
            public string MemberName { get; set; }

            [DisplayName("Member Address")]
            public string MemberAddress { get; set; }

            [DisplayName("Phone Number")]
            public Nullable<int> MemberPhone { get; set; }


        }
    }
}