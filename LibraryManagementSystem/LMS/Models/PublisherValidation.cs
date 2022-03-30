using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    [MetadataType(typeof(PublisherMetaData))]
    public partial class Publisher
    {
        public class PublisherMetaData
        {
            [DisplayName("Publisher Name")]
            public string PubName { get; set; }

            [DisplayName("PubAddress")]
            public string PubAddress { get; set; }

            [DisplayName("PubPhone")]
            public string PubPhone { get; set; }


        }
    }
}