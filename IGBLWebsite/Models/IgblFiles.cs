using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class IgblFiles
    {
        public string Filename { get; set; }
        public int? Filesize { get; set; }
        public string Description { get; set; }
        public DateTime? Uploaded { get; set; }
        public bool? Staff { get; set; }
        public int? UserFk { get; set; }
    }
}
