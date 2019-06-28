using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class Matches
    {
        public int MatchPk { get; set; }
        public int SeasonFk { get; set; }
        public int MatchTypeFk { get; set; }
        public int Round { get; set; }
        public DateTime? MatchDate { get; set; }
        public int? Squad1Fk { get; set; }
        public int? Squad2Fk { get; set; }
        public int? Squad1Mvp { get; set; }
        public int? Squad2Mvp { get; set; }
        public int? RefereeFk { get; set; }
        public string RefereeComments { get; set; }
        public int? WinningSquad { get; set; }
        public bool Complete { get; set; }
    }
}
