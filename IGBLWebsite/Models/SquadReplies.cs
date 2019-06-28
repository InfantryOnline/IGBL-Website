using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class SquadReplies
    {
        public int ReplyPk { get; set; }
        public int PostFk { get; set; }
        public int UserFk { get; set; }
        public DateTime? ReplyDate { get; set; }
        public string ReplyBody { get; set; }
        public DateTime? EditDate { get; set; }
        public bool? Active { get; set; }

        public virtual SquadPosts PostFkNavigation { get; set; }
        public virtual Users UserFkNavigation { get; set; }
    }
}
