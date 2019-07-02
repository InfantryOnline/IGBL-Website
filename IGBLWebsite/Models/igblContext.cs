using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IGBLWebsite.Models
{
    public partial class igblContext : DbContext
    {
        public igblContext(DbContextOptions<igblContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Awards> Awards { get; set; }
        public virtual DbSet<Divisions> Divisions { get; set; }
        public virtual DbSet<Dtproperties> Dtproperties { get; set; }
        public virtual DbSet<Dtproperties1> Dtproperties1 { get; set; }
        public virtual DbSet<ForumPosts> ForumPosts { get; set; }
        public virtual DbSet<ForumReplies> ForumReplies { get; set; }
        public virtual DbSet<IgblFiles> IgblFiles { get; set; }
        public virtual DbSet<LadderMatches> LadderMatches { get; set; }
        public virtual DbSet<MatchResults> MatchResults { get; set; }
        public virtual DbSet<MatchTypes> MatchTypes { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComment { get; set; }
        public virtual DbSet<PollAnswers> PollAnswers { get; set; }
        public virtual DbSet<PollChoice> PollChoice { get; set; }
        public virtual DbSet<PollQuestions> PollQuestions { get; set; }
        public virtual DbSet<PrivateMessages> PrivateMessages { get; set; }
        public virtual DbSet<PrivateMessagesGroups> PrivateMessagesGroups { get; set; }
        public virtual DbSet<PrivateMessagesGroupsDetails> PrivateMessagesGroupsDetails { get; set; }
        public virtual DbSet<PrivateMessagesIgnore> PrivateMessagesIgnore { get; set; }
        public virtual DbSet<SearchLog> SearchLog { get; set; }
        public virtual DbSet<Seasons> Seasons { get; set; }
        public virtual DbSet<SquadAdmins> SquadAdmins { get; set; }
        public virtual DbSet<SquadOffers> SquadOffers { get; set; }
        public virtual DbSet<SquadPosts> SquadPosts { get; set; }
        public virtual DbSet<SquadReplies> SquadReplies { get; set; }
        public virtual DbSet<Squads> Squads { get; set; }
        public virtual DbSet<UserAliasLog> UserAliasLog { get; set; }
        public virtual DbSet<UserIgblStaff> UserIgblStaff { get; set; }
        public virtual DbSet<UserIgblStaffPositions> UserIgblStaffPositions { get; set; }
        public virtual DbSet<UserPredictions> UserPredictions { get; set; }
        public virtual DbSet<UserRanks> UserRanks { get; set; }
        public virtual DbSet<UserRolesValid> UserRolesValid { get; set; }
        public virtual DbSet<UserStatistics> UserStatistics { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WebsiteTraffic> WebsiteTraffic { get; set; }
        public virtual DbSet<SiteAdmin> SiteAdmin { get; set; }

        // Unable to generate entity type for table 'dudektk_igbl1.Award_Results_Individual'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Award_Results_Team'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Banned_IPs'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Donations'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Forum_Categories'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Forum_Delete_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Forum_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Forum_User_Post_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.IGBL_Rules'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.IP_Search_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Ladder'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Ladder_Movement'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Ladder_User_Totals'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Site_Admin'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Squad_Divisions'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.Squad_User_Post_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.User_Name_History'. Please see the warning messages.
        // Unable to generate entity type for table 'dudektk_igbl1.User_Roles_Assigned'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CDATA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CGLOBAL'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Awards>(entity =>
            {
                entity.HasKey(e => e.AwardPk);

                entity.ToTable("Awards", "dudektk_igbl1");

                entity.Property(e => e.AwardPk).HasColumnName("Award_PK");

                entity.Property(e => e.AwardBlurb)
                    .HasColumnName("Award_Blurb")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AwardDesc)
                    .HasColumnName("Award_Desc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AwardTitle)
                    .HasColumnName("Award_Title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AwardType)
                    .IsRequired()
                    .HasColumnName("Award_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AwardUnits)
                    .HasColumnName("Award_Units")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BigImage)
                    .HasColumnName("Big_Image")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmlImage)
                    .HasColumnName("Sml_Image")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");
            });

            modelBuilder.Entity<Divisions>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("Divisions", "dudektk_igbl1");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasColumnName("Division_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dtproperties>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Property })
                    .HasName("pk_dtproperties");

                entity.ToTable("dtproperties", "dudektk_igbl1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Property)
                    .HasColumnName("property")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Lvalue)
                    .HasColumnName("lvalue")
                    .HasColumnType("image");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Uvalue)
                    .HasColumnName("uvalue")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Dtproperties1>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Property })
                    .HasName("pk_dtproperties");

                entity.ToTable("dtproperties");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Property)
                    .HasColumnName("property")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Lvalue)
                    .HasColumnName("lvalue")
                    .HasColumnType("image");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Uvalue)
                    .HasColumnName("uvalue")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<ForumPosts>(entity =>
            {
                entity.HasKey(e => e.PostPk);

                entity.ToTable("Forum_Posts", "dudektk_igbl1");

                entity.Property(e => e.PostPk).HasColumnName("Post_PK");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AdminLock).HasColumnName("Admin_Lock");

                entity.Property(e => e.AdminLockByUserFk).HasColumnName("Admin_Lock_By_User_FK");

                entity.Property(e => e.CategoryFk).HasColumnName("Category_FK");

                entity.Property(e => e.EditByUserFk).HasColumnName("Edit_By_User_FK");

                entity.Property(e => e.EditDate)
                    .HasColumnName("Edit_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostBody)
                    .HasColumnName("Post_Body")
                    .HasColumnType("text");

                entity.Property(e => e.PostDate)
                    .HasColumnName("Post_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostSubject)
                    .HasColumnName("Post_Subject")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<ForumReplies>(entity =>
            {
                entity.HasKey(e => e.ReplyPk);

                entity.ToTable("Forum_Replies", "dudektk_igbl1");

                entity.HasIndex(e => e.PostFk)
                    .HasName("INDX_REPLIES_Post_FK");

                entity.Property(e => e.ReplyPk).HasColumnName("Reply_PK");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EditByUserFk).HasColumnName("Edit_By_User_FK");

                entity.Property(e => e.EditDate)
                    .HasColumnName("Edit_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostFk).HasColumnName("Post_FK");

                entity.Property(e => e.ReplyBody)
                    .HasColumnName("Reply_Body")
                    .HasColumnType("text");

                entity.Property(e => e.ReplyDate)
                    .HasColumnName("Reply_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<IgblFiles>(entity =>
            {
                entity.HasKey(e => e.Filename);

                entity.ToTable("IGBL_Files", "dudektk_igbl1");

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Staff).HasDefaultValueSql("((0))");

                entity.Property(e => e.Uploaded).HasColumnType("datetime");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<LadderMatches>(entity =>
            {
                entity.HasKey(e => e.MatchPk);

                entity.ToTable("Ladder_Matches", "dudektk_igbl1");

                entity.Property(e => e.MatchPk)
                    .HasColumnName("Match_PK")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfirmedBy1Fk).HasColumnName("Confirmed_By_1_FK");

                entity.Property(e => e.ConfirmedBy2Fk).HasColumnName("Confirmed_By_2_FK");

                entity.Property(e => e.MatchDate)
                    .HasColumnName("Match_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefFk).HasColumnName("Ref_FK");

                entity.Property(e => e.Squad11Fk).HasColumnName("Squad1_1_FK");

                entity.Property(e => e.Squad11Rank).HasColumnName("Squad1_1_Rank");

                entity.Property(e => e.Squad12Fk).HasColumnName("Squad1_2_FK");

                entity.Property(e => e.Squad12Rank).HasColumnName("Squad1_2_Rank");

                entity.Property(e => e.Squad13Fk).HasColumnName("Squad1_3_FK");

                entity.Property(e => e.Squad13Rank).HasColumnName("Squad1_3_Rank");

                entity.Property(e => e.Squad14Fk).HasColumnName("Squad1_4_FK");

                entity.Property(e => e.Squad14Rank).HasColumnName("Squad1_4_Rank");

                entity.Property(e => e.Squad15Fk).HasColumnName("SQUAD1_5_FK");

                entity.Property(e => e.Squad15Rank).HasColumnName("Squad1_5_Rank");

                entity.Property(e => e.Squad16Fk).HasColumnName("Squad1_6_FK");

                entity.Property(e => e.Squad16Rank).HasColumnName("Squad1_6_Rank");

                entity.Property(e => e.Squad1Score).HasColumnName("Squad1_Score");

                entity.Property(e => e.Squad21Fk).HasColumnName("Squad2_1_FK");

                entity.Property(e => e.Squad21Rank).HasColumnName("Squad2_1_Rank");

                entity.Property(e => e.Squad22Fk).HasColumnName("Squad2_2_FK");

                entity.Property(e => e.Squad22Rank).HasColumnName("Squad2_2_Rank");

                entity.Property(e => e.Squad23Fk).HasColumnName("Squad2_3_FK");

                entity.Property(e => e.Squad23Rank).HasColumnName("Squad2_3_Rank");

                entity.Property(e => e.Squad24Fk).HasColumnName("Squad2_4_FK");

                entity.Property(e => e.Squad24Rank).HasColumnName("Squad2_4_Rank");

                entity.Property(e => e.Squad25Fk).HasColumnName("SQUAD2_5_FK");

                entity.Property(e => e.Squad25Rank).HasColumnName("Squad2_5_Rank");

                entity.Property(e => e.Squad26Fk).HasColumnName("Squad2_6_FK");

                entity.Property(e => e.Squad26Rank).HasColumnName("Squad2_6_Rank");

                entity.Property(e => e.Squad2Score).HasColumnName("Squad2_Score");

                entity.Property(e => e.WinningSquad).HasColumnName("Winning_Squad");
            });

            modelBuilder.Entity<MatchResults>(entity =>
            {
                entity.HasKey(e => e.MatchResultPk);

                entity.ToTable("Match_Results", "dudektk_igbl1");

                entity.Property(e => e.MatchResultPk).HasColumnName("Match_Result_PK");

                entity.Property(e => e.GameMinutes).HasColumnName("Game_Minutes");

                entity.Property(e => e.MatchFk).HasColumnName("Match_FK");

                entity.Property(e => e.RefereeComment)
                    .HasColumnName("Referee_Comment")
                    .HasColumnType("text");

                entity.Property(e => e.Squad1Score).HasColumnName("Squad1_Score");

                entity.Property(e => e.Squad2Score).HasColumnName("Squad2_Score");
            });

            modelBuilder.Entity<MatchTypes>(entity =>
            {
                entity.HasKey(e => e.MatchTypePk);

                entity.ToTable("Match_Types", "dudektk_igbl1");

                entity.Property(e => e.MatchTypePk).HasColumnName("Match_Type_PK");

                entity.Property(e => e.MatchType)
                    .HasColumnName("Match_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.HasKey(e => e.MatchPk);

                entity.ToTable("Matches", "dudektk_igbl1");

                entity.Property(e => e.MatchPk).HasColumnName("Match_PK");

                entity.Property(e => e.MatchDate)
                    .HasColumnName("Match_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchTypeFk).HasColumnName("Match_Type_FK");

                entity.Property(e => e.RefereeComments)
                    .HasColumnName("Referee_Comments")
                    .HasColumnType("text");

                entity.Property(e => e.RefereeFk).HasColumnName("Referee_FK");

                entity.Property(e => e.SeasonFk).HasColumnName("Season_FK");

                entity.Property(e => e.Squad1Fk).HasColumnName("Squad1_FK");

                entity.Property(e => e.Squad1Mvp).HasColumnName("Squad1_MVP");

                entity.Property(e => e.Squad2Fk).HasColumnName("Squad2_FK");

                entity.Property(e => e.Squad2Mvp).HasColumnName("Squad2_MVP");

                entity.Property(e => e.WinningSquad).HasColumnName("Winning_Squad");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasKey(e => e.NewsPk);

                entity.ToTable("News", "dudektk_igbl1");

                entity.Property(e => e.NewsPk).HasColumnName("News_PK");

                entity.Property(e => e.NewsBody)
                    .HasColumnName("News_Body")
                    .HasColumnType("text");

                entity.Property(e => e.PostDate)
                    .HasColumnName("Post_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<NewsComment>(entity =>
            {
                entity.HasKey(e => e.CommentPk)
                    .HasName("PK_News_Comment_1");

                entity.ToTable("News_Comment", "dudektk_igbl1");

                entity.Property(e => e.CommentPk).HasColumnName("Comment_PK");

                entity.Property(e => e.CommentBody)
                    .HasColumnName("Comment_Body")
                    .HasColumnType("text");

                entity.Property(e => e.NewsFk).HasColumnName("News_FK");

                entity.Property(e => e.PostDate)
                    .HasColumnName("Post_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<PollAnswers>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.ToTable("Poll_Answers", "dudektk_igbl1");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.ChoiceFk).HasColumnName("Choice_FK");

                entity.Property(e => e.QuestionFk).HasColumnName("Question_FK");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<PollChoice>(entity =>
            {
                entity.HasKey(e => e.ChoicePk);

                entity.ToTable("Poll_Choice", "dudektk_igbl1");

                entity.Property(e => e.ChoicePk).HasColumnName("Choice_PK");

                entity.Property(e => e.Choice)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionFk).HasColumnName("Question_FK");
            });

            modelBuilder.Entity<PollQuestions>(entity =>
            {
                entity.HasKey(e => e.QuestionPk);

                entity.ToTable("Poll_Questions", "dudektk_igbl1");

                entity.Property(e => e.QuestionPk).HasColumnName("Question_PK");

                entity.Property(e => e.ChangeVote)
                    .IsRequired()
                    .HasColumnName("Change_Vote")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HiddenPoll).HasColumnName("Hidden_Poll");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType).HasColumnName("Question_Type");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<PrivateMessages>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.UserFk });

                entity.ToTable("Private_Messages", "dudektk_igbl1");

                entity.HasIndex(e => new { e.UserFk, e.Viewed })
                    .HasName("IX_Private_Messages");

                entity.Property(e => e.MessageId)
                    .HasColumnName("Message_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserFk).HasColumnName("User_FK");

                entity.Property(e => e.ChainId).HasColumnName("Chain_ID");

                entity.Property(e => e.FromUserFk).HasColumnName("From_User_FK");

                entity.Property(e => e.MessageData)
                    .HasColumnName("Message_Data")
                    .HasColumnType("text");

                entity.Property(e => e.MessageDate)
                    .HasColumnName("Message_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MessageReply).HasColumnName("Message_Reply");

                entity.Property(e => e.MessageSubject)
                    .HasColumnName("Message_Subject")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalMessage).HasColumnName("Original_Message");
            });

            modelBuilder.Entity<PrivateMessagesGroups>(entity =>
            {
                entity.HasKey(e => e.GroupPk)
                    .HasName("PK_Private_Messages_Group");

                entity.ToTable("Private_Messages_Groups", "dudektk_igbl1");

                entity.HasIndex(e => new { e.GroupName, e.OwnerUserFk })
                    .HasName("IX_Private_Messages_Groups")
                    .IsUnique();

                entity.Property(e => e.GroupPk).HasColumnName("Group_PK");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("Group_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerUserFk).HasColumnName("Owner_User_FK");
            });

            modelBuilder.Entity<PrivateMessagesGroupsDetails>(entity =>
            {
                entity.HasKey(e => e.RecordPk)
                    .HasName("PK_Private_Messages_Groups");

                entity.ToTable("Private_Messages_Groups_Details", "dudektk_igbl1");

                entity.Property(e => e.RecordPk).HasColumnName("Record_PK");

                entity.Property(e => e.GroupFk).HasColumnName("Group_FK");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<PrivateMessagesIgnore>(entity =>
            {
                entity.HasKey(e => e.IgnoreId);

                entity.ToTable("Private_Messages_Ignore", "dudektk_igbl1");

                entity.Property(e => e.IgnoreId).HasColumnName("Ignore_ID");

                entity.Property(e => e.IgnoreUserFk).HasColumnName("Ignore_User_FK");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<SearchLog>(entity =>
            {
                entity.HasKey(e => e.SearchPk);

                entity.ToTable("Search_Log", "dudektk_igbl1");

                entity.Property(e => e.SearchPk).HasColumnName("Search_PK");

                entity.Property(e => e.SearchDateTime).HasColumnType("datetime");

                entity.Property(e => e.SearchString)
                    .IsRequired()
                    .HasColumnName("Search_String")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<Seasons>(entity =>
            {
                entity.HasKey(e => e.SeasonPk);

                entity.ToTable("Seasons", "dudektk_igbl1");

                entity.Property(e => e.SeasonPk)
                    .HasColumnName("Season_PK")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateBegin)
                    .HasColumnName("Date_Begin")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("Date_End")
                    .HasColumnType("datetime");

                entity.Property(e => e.SeasonName)
                    .HasColumnName("Season_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SeasonOrder).HasColumnName("Season_Order");
            });

            modelBuilder.Entity<SquadAdmins>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.ToTable("Squad_Admins", "dudektk_igbl1");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.AdminType).HasColumnName("Admin_Type");

                entity.Property(e => e.SquadFk).HasColumnName("Squad_FK");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<SquadOffers>(entity =>
            {
                entity.HasKey(e => e.OfferPk);

                entity.ToTable("Squad_Offers", "dudektk_igbl1");

                entity.Property(e => e.OfferPk).HasColumnName("OfferPK");

                entity.Property(e => e.DateAccepted)
                    .HasColumnName("Date_Accepted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOffered)
                    .HasColumnName("Date_Offered")
                    .HasColumnType("datetime");

                entity.Property(e => e.OfferedByUserFk).HasColumnName("Offered_By_User_FK");

                entity.Property(e => e.OfferedToUserFk).HasColumnName("Offered_To_User_FK");

                entity.Property(e => e.SquadFk).HasColumnName("Squad_FK");
            });

            modelBuilder.Entity<SquadPosts>(entity =>
            {
                entity.HasKey(e => e.PostPk);

                entity.ToTable("Squad_Posts", "dudektk_igbl1");

                entity.Property(e => e.PostPk).HasColumnName("Post_PK");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AdminLock).HasColumnName("Admin_Lock");

                entity.Property(e => e.EditDate)
                    .HasColumnName("Edit_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostBody)
                    .HasColumnName("Post_Body")
                    .HasColumnType("text");

                entity.Property(e => e.PostDate)
                    .HasColumnName("Post_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostSubject)
                    .HasColumnName("Post_Subject")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SquadFk).HasColumnName("Squad_FK");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<SquadReplies>(entity =>
            {
                entity.HasKey(e => e.ReplyPk);

                entity.ToTable("Squad_Replies", "dudektk_igbl1");

                entity.Property(e => e.ReplyPk).HasColumnName("Reply_PK");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EditDate)
                    .HasColumnName("Edit_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostFk).HasColumnName("Post_FK");

                entity.Property(e => e.ReplyBody)
                    .HasColumnName("Reply_Body")
                    .HasColumnType("text");

                entity.Property(e => e.ReplyDate)
                    .HasColumnName("Reply_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");

                entity.HasOne(d => d.PostFkNavigation)
                    .WithMany(p => p.SquadReplies)
                    .HasForeignKey(d => d.PostFk)
                    .HasConstraintName("FK_Squad_Replies_Squad_Posts");

                entity.HasOne(d => d.UserFkNavigation)
                    .WithMany(p => p.SquadReplies)
                    .HasForeignKey(d => d.UserFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Squad_Replies_Users");
            });

            modelBuilder.Entity<Squads>(entity =>
            {
                entity.HasKey(e => e.SquadPk);

                entity.ToTable("Squads", "dudektk_igbl1");

                entity.Property(e => e.SquadPk).HasColumnName("Squad_PK");

                entity.Property(e => e.CaptainsComments)
                    .HasColumnName("Captains_Comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("Creation_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SquadImageUrl)
                    .HasColumnName("Squad_Image_URL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SquadName)
                    .HasColumnName("Squad_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SquadWebsiteUrl)
                    .HasColumnName("Squad_Website_URL")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAliasLog>(entity =>
            {
                entity.HasKey(e => e.LogPk);

                entity.ToTable("User_Alias_Log", "dudektk_igbl1");

                entity.HasIndex(e => e.UserFk)
                    .HasName("IX_User_Alias_Log");

                entity.Property(e => e.LogPk).HasColumnName("Log_PK");

                entity.Property(e => e.DateChanged)
                    .HasColumnName("Date_Changed")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhoChanged).HasColumnName("Who_Changed");
            });

            modelBuilder.Entity<UserIgblStaff>(entity =>
            {
                entity.HasKey(e => e.StaffPk);

                entity.ToTable("User_IGBL_Staff", "dudektk_igbl1");

                entity.Property(e => e.StaffPk).HasColumnName("Staff_PK");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<UserIgblStaffPositions>(entity =>
            {
                entity.HasKey(e => e.StaffPk);

                entity.ToTable("User_IGBL_Staff_Positions", "dudektk_igbl1");

                entity.Property(e => e.StaffPk).HasColumnName("Staff_PK");

                entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");

                entity.Property(e => e.StaffPositionName)
                    .HasColumnName("Staff_Position_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserPredictions>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.ToTable("User_Predictions", "dudektk_igbl1");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.Dtime)
                    .HasColumnName("dtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchFk).HasColumnName("Match_FK");

                entity.Property(e => e.PickedSquad).HasColumnName("Picked_Squad");

                entity.Property(e => e.Squad1Vote).HasColumnName("Squad1_Vote");

                entity.Property(e => e.Squad2Vote).HasColumnName("Squad2_Vote");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");
            });

            modelBuilder.Entity<UserRanks>(entity =>
            {
                entity.HasKey(e => e.RankPk);

                entity.ToTable("User_Ranks", "dudektk_igbl1");

                entity.Property(e => e.RankPk).HasColumnName("Rank_PK");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RankImage)
                    .HasColumnName("Rank_Image")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasColumnName("Rank_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RankOrder).HasColumnName("Rank_Order");

                entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");
            });

            modelBuilder.Entity<UserRolesValid>(entity =>
            {
                entity.HasKey(e => e.RoleName);

                entity.ToTable("User_Roles_Valid", "dudektk_igbl1");

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleComments)
                    .HasColumnName("Role_Comments")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserStatistics>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.ToTable("User_Statistics", "dudektk_igbl1");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.CarryTime).HasColumnName("Carry_Time");

                entity.Property(e => e.Losses).HasColumnType("numeric(10, 1)");

                entity.Property(e => e.MatchMvps).HasColumnName("Match_MVPs");

                entity.Property(e => e.MvpPoints).HasColumnName("MVP_Points");

                entity.Property(e => e.PlaySeconds).HasColumnName("Play_Seconds");

                entity.Property(e => e.SeasonFk).HasColumnName("Season_FK");

                entity.Property(e => e.SquadFk).HasColumnName("Squad_FK");

                entity.Property(e => e.StatType)
                    .IsRequired()
                    .HasColumnName("Stat_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserFk).HasColumnName("User_FK");

                entity.Property(e => e.Wins).HasColumnType("numeric(10, 1)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserPk)
                    .HasName("PK_Users_1");

                entity.ToTable("Users", "dudektk_igbl1");

                entity.Property(e => e.UserPk).HasColumnName("User_PK");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AdminAvatarSwitch)
                    .IsRequired()
                    .HasColumnName("Admin_Avatar_Switch")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Aim)
                    .HasColumnName("AIM")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEligibleForSquad)
                    .HasColumnName("Date_Eligible_For_Squad")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateJoinedIgbl)
                    .HasColumnName("Date_Joined_IGBL")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateJoinedSquad)
                    .HasColumnName("Date_Joined_Squad")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForumBodyDisplay)
                    .IsRequired()
                    .HasColumnName("Forum_Body_Display")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ForumNotification)
                    .IsRequired()
                    .HasColumnName("Forum_Notification")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Icq)
                    .HasColumnName("ICQ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IrcIdentPass)
                    .HasColumnName("IRC_Ident_Pass")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IrcNick)
                    .HasColumnName("IRC_Nick")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastVisit)
                    .HasColumnName("Last_Visit")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msn)
                    .HasColumnName("MSN")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PollNotification)
                    .IsRequired()
                    .HasColumnName("Poll_Notification")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrivMsgEmail).HasColumnName("Priv_Msg_Email");

                entity.Property(e => e.PrivateMessages)
                    .IsRequired()
                    .HasColumnName("Private_Messages")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RankCommunity)
                    .HasColumnName("Rank_Community")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RankIgblskill)
                    .HasColumnName("Rank_IGBLSkill")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RankOsi)
                    .HasColumnName("Rank_Osi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RankReferee)
                    .HasColumnName("Rank_Referee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RankSeasons)
                    .HasColumnName("Rank_Seasons")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RankSiteLength)
                    .HasColumnName("Rank_Site_Length")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RankTotal)
                    .HasColumnName("Rank_Total")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SquadActive).HasColumnName("Squad_Active");

                entity.Property(e => e.SquadId).HasColumnName("Squad_ID");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAvatarSwitch)
                    .IsRequired()
                    .HasColumnName("User_Avatar_Switch")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserAvatarUrl)
                    .HasColumnName("User_Avatar_URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserBannerUrl)
                    .HasColumnName("User_Banner_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserComments)
                    .HasColumnName("User_Comments")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRankId).HasColumnName("User_Rank_ID");

                entity.Property(e => e.UserSex)
                    .HasColumnName("User_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserWebsiteUrl)
                    .HasColumnName("User_Website_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteStyle)
                    .HasColumnName("Website_Style")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.UserRank)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRankId)
                    .HasConstraintName("FK_Users_User_IGBL_Staff_Positions");
            });

            modelBuilder.Entity<WebsiteTraffic>(entity =>
            {
                entity.HasKey(e => e.TrafficPk);

                entity.ToTable("Website_Traffic", "dudektk_igbl1");

                entity.Property(e => e.TrafficPk).HasColumnName("Traffic_PK");

                entity.Property(e => e.DateVisited)
                    .HasColumnName("Date_Visited")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserAgent)
                    .HasColumnName("User_Agent")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserFk).HasColumnName("User_FK");

                entity.Property(e => e.UserIp)
                    .HasColumnName("User_IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserReferer)
                    .HasColumnName("User_Referer")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteAdmin>(entity =>
            {
                entity.Property(e => e.ConfigId).HasColumnName("Config_ID");

                entity.HasKey(e => e.ConfigId);

                entity.ToTable("Site_Admin", "dudektk_igbl1");

                entity.Property(e => e.ServerSetting)
                    .HasColumnName("Server_Setting")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
