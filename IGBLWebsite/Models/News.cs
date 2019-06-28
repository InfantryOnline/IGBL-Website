using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class News
    {
        public int NewsPk { get; set; }
        public int UserFk { get; set; }
        public DateTime PostDate { get; set; }
        public string Subject { get; set; }
        public string NewsBody { get; set; }
        public bool Active { get; set; }
        public int Comments { get; set; }
    }
}
