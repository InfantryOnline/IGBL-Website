using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class PollAnswers
    {
        public int Pk { get; set; }
        public int UserFk { get; set; }
        public int QuestionFk { get; set; }
        public int ChoiceFk { get; set; }
    }
}
