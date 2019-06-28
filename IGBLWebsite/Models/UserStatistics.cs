using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class UserStatistics
    {
        public int Pk { get; set; }
        public int SeasonFk { get; set; }
        public string StatType { get; set; }
        public int UserFk { get; set; }
        public int SquadFk { get; set; }
        public long PlaySeconds { get; set; }
        public decimal Wins { get; set; }
        public decimal Losses { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Catches { get; set; }
        public int Steals { get; set; }
        public int Passes { get; set; }
        public int Fumbles { get; set; }
        public int CarryTime { get; set; }
        public int Saves { get; set; }
        public int Pinches { get; set; }
        public long Points { get; set; }
        public long MvpPoints { get; set; }
        public int MatchMvps { get; set; }
    }
}
