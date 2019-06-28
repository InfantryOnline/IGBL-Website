using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class UserAliasLog
    {
        public int LogPk { get; set; }
        public int UserFk { get; set; }
        public string UserId { get; set; }
        public int Season { get; set; }
        public DateTime? DateChanged { get; set; }
        public int? WhoChanged { get; set; }
    }
}
