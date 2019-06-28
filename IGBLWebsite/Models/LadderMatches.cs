using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class LadderMatches
    {
        public string MatchPk { get; set; }
        public int? RefFk { get; set; }
        public DateTime? MatchDate { get; set; }
        public int? WinningSquad { get; set; }
        public int? Squad1Score { get; set; }
        public int? Squad2Score { get; set; }
        public int? Squad11Fk { get; set; }
        public int? Squad12Fk { get; set; }
        public int? Squad13Fk { get; set; }
        public int? Squad14Fk { get; set; }
        public int? Squad21Fk { get; set; }
        public int? Squad22Fk { get; set; }
        public int? Squad23Fk { get; set; }
        public int? Squad24Fk { get; set; }
        public int? ConfirmedBy1Fk { get; set; }
        public int? ConfirmedBy2Fk { get; set; }
        public bool? Active { get; set; }
        public int? Squad15Fk { get; set; }
        public int? Squad25Fk { get; set; }
        public int? Squad11Rank { get; set; }
        public int? Squad12Rank { get; set; }
        public int? Squad13Rank { get; set; }
        public int? Squad14Rank { get; set; }
        public int? Squad15Rank { get; set; }
        public int? Squad21Rank { get; set; }
        public int? Squad22Rank { get; set; }
        public int? Squad23Rank { get; set; }
        public int? Squad24Rank { get; set; }
        public int? Squad25Rank { get; set; }
        public int? Squad16Fk { get; set; }
        public int? Squad16Rank { get; set; }
        public int? Squad26Fk { get; set; }
        public int? Squad26Rank { get; set; }
    }
}
