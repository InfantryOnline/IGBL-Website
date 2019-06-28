using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class ForumReplies
    {
        public int ReplyPk { get; set; }
        public int PostFk { get; set; }
        public int UserFk { get; set; }
        public DateTime? ReplyDate { get; set; }
        public string ReplyBody { get; set; }
        public DateTime? EditDate { get; set; }
        public bool? Active { get; set; }
        public int? EditByUserFk { get; set; }
    }
}
