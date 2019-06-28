using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class PrivateMessagesIgnore
    {
        public int IgnoreId { get; set; }
        public int UserFk { get; set; }
        public int IgnoreUserFk { get; set; }
    }
}
