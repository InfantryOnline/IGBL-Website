using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class NewsComment
    {
        public int CommentPk { get; set; }
        public int NewsFk { get; set; }
        public int UserFk { get; set; }
        public DateTime PostDate { get; set; }
        public string CommentBody { get; set; }
    }
}
