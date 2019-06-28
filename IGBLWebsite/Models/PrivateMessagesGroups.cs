using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class PrivateMessagesGroups
    {
        public int GroupPk { get; set; }
        public string GroupName { get; set; }
        public int OwnerUserFk { get; set; }
    }
}
