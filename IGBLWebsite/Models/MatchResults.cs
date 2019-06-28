using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class MatchResults
    {
        public int MatchResultPk { get; set; }
        public int MatchFk { get; set; }
        public int Game { get; set; }
        public int? Squad1Score { get; set; }
        public int? Squad2Score { get; set; }
        public int? GameMinutes { get; set; }
        public string RefereeComment { get; set; }
        public bool Forfeit { get; set; }
    }
}
