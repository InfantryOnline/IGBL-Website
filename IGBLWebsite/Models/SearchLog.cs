using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class SearchLog
    {
        public int SearchPk { get; set; }
        public int UserFk { get; set; }
        public DateTime SearchDateTime { get; set; }
        public string SearchString { get; set; }
    }
}
