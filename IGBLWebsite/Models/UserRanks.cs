using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class UserRanks
    {
        public int RankPk { get; set; }
        public int? RankOrder { get; set; }
        public string RankName { get; set; }
        public string RankImage { get; set; }
        public int? SortOrder { get; set; }
        public bool? Active { get; set; }
    }
}
