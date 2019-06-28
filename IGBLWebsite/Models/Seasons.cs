using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class Seasons
    {
        public int SeasonPk { get; set; }
        public int? SeasonOrder { get; set; }
        public string SeasonName { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
