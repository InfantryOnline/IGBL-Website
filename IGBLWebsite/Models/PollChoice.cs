using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class PollChoice
    {
        public int ChoicePk { get; set; }
        public int QuestionFk { get; set; }
        public string Choice { get; set; }
    }
}
