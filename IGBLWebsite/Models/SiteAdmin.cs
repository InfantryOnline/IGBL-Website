using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IGBLWebsite.Models
{
    public partial class SiteAdmin
    {
        public int ConfigId { get; set; }

        public string ServerSetting { get; set; }

        public bool? Setting1 { get; set; } 

        public int? Setting2 { get; set; }
    }
}
