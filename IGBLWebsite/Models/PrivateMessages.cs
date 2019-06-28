using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class PrivateMessages
    {
        public int MessageId { get; set; }
        public int UserFk { get; set; }
        public int FromUserFk { get; set; }
        public DateTime? MessageDate { get; set; }
        public string MessageSubject { get; set; }
        public string MessageData { get; set; }
        public bool Viewed { get; set; }
        public bool MessageReply { get; set; }
        public int? ChainId { get; set; }
        public bool Deleted { get; set; }
        public bool OriginalMessage { get; set; }
    }
}
