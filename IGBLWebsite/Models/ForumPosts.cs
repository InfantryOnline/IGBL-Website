using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class ForumPosts
    {
        public int PostPk { get; set; }
        public int CategoryFk { get; set; }
        public int UserFk { get; set; }
        public DateTime? PostDate { get; set; }
        public string PostSubject { get; set; }
        public string PostBody { get; set; }
        public int Viewed { get; set; }
        public bool Sticky { get; set; }
        public bool Locked { get; set; }
        public bool AdminLock { get; set; }
        public bool? Active { get; set; }
        public DateTime? EditDate { get; set; }
        public int? EditByUserFk { get; set; }
        public int? AdminLockByUserFk { get; set; }
    }
}
