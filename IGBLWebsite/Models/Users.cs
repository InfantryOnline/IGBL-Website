using System;
using System.Collections.Generic;

namespace IGBLWebsite.Models
{
    public partial class Users
    {
        public Users()
        {
            SquadReplies = new HashSet<SquadReplies>();
        }

        public int UserPk { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool? Active { get; set; }
        public int? UserRankId { get; set; }
        public int? SquadId { get; set; }
        public bool SquadActive { get; set; }
        public DateTime? DateEligibleForSquad { get; set; }
        public DateTime? DateJoinedSquad { get; set; }
        public DateTime DateJoinedIgbl { get; set; }
        public string UserComments { get; set; }
        public string UserBannerUrl { get; set; }
        public string UserWebsiteUrl { get; set; }
        public string UserAvatarUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserSex { get; set; }
        public string Email { get; set; }
        public string Msn { get; set; }
        public string Aim { get; set; }
        public string Icq { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Occupation { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? LastVisit { get; set; }
        public bool? UserAvatarSwitch { get; set; }
        public bool? AdminAvatarSwitch { get; set; }
        public int? RankIgblskill { get; set; }
        public int? RankCommunity { get; set; }
        public int? RankSiteLength { get; set; }
        public int? RankSeasons { get; set; }
        public int? RankReferee { get; set; }
        public int? RankOsi { get; set; }
        public int? RankTotal { get; set; }
        public int WebsiteStyle { get; set; }
        public bool? PrivateMessages { get; set; }
        public bool? ForumNotification { get; set; }
        public string IrcNick { get; set; }
        public string IrcIdentPass { get; set; }
        public bool PrivMsgEmail { get; set; }
        public bool? ForumBodyDisplay { get; set; }
        public bool? PollNotification { get; set; }

        public virtual UserIgblStaffPositions UserRank { get; set; }
        public virtual ICollection<SquadReplies> SquadReplies { get; set; }
    }
}
