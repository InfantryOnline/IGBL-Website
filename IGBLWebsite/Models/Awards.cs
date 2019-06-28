using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class Awards
    {
        public int AwardPk { get; set; }
        public string AwardTitle { get; set; }
        public string AwardBlurb { get; set; }
        public string AwardDesc { get; set; }
        public string AwardType { get; set; }
        public string AwardUnits { get; set; }
        public string BigImage { get; set; }
        public string SmlImage { get; set; }
        public int? SortOrder { get; set; }
        public bool Active { get; set; }
    }
}
