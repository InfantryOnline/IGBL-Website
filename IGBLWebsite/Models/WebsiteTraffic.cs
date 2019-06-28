using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class WebsiteTraffic
    {
        public long TrafficPk { get; set; }
        public int? UserFk { get; set; }
        public DateTime? DateVisited { get; set; }
        public string UserIp { get; set; }
        public string UserAgent { get; set; }
        public string UserReferer { get; set; }
    }
}
