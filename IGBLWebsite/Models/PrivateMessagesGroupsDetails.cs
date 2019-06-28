using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class PrivateMessagesGroupsDetails
    {
        public int RecordPk { get; set; }
        public int GroupFk { get; set; }
        public int UserFk { get; set; }
    }
}
