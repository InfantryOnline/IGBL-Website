using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class PollQuestions
    {
        public int QuestionPk { get; set; }
        public string Question { get; set; }
        public DateTime? EndDate { get; set; }
        public bool QuestionType { get; set; }
        public bool Active { get; set; }
        public bool HiddenPoll { get; set; }
        public bool? ChangeVote { get; set; }
        public int? UserFk { get; set; }
    }
}
