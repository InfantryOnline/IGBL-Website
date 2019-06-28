using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class SquadAdmins
    {
        public int Pk { get; set; }
        public int AdminType { get; set; }
        public int SquadFk { get; set; }
        public int UserFk { get; set; }
    }
}
