using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class UserPredictions
    {
        public int Pk { get; set; }
        public int MatchFk { get; set; }
        public int UserFk { get; set; }
        public int? Squad1Vote { get; set; }
        public int? Squad2Vote { get; set; }
        public int? PickedSquad { get; set; }
        public string Comments { get; set; }
        public DateTime? Dtime { get; set; }
    }
}
