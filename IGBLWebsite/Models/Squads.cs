using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class Squads
    {
        public int SquadPk { get; set; }
        public string SquadName { get; set; }
        public int? Division { get; set; }
        public DateTime CreationDate { get; set; }
        public string CaptainsComments { get; set; }
        public string SquadImageUrl { get; set; }
        public string SquadWebsiteUrl { get; set; }
        public bool Active { get; set; }
    }
}
