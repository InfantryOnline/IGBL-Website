using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IGBLWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IGBLWebsite.Areas.Players.Pages
{
    public class ViewModel : PageModel
    {
        public class PlayerViewModel
        {
            public Users User { get; set; }

            public UserRanks Rank { get; set; }

            public List<SeasonStatsEntry> SeasonStatEntries { get; set; } = new List<SeasonStatsEntry>();

            public List<Awards> Awards { get; set; } = new List<Awards>();

            public decimal CareerRating
            {
                get
                {
                    // This is extracted from the T-SQL View "Career_Ratings_Sub"
                    var totalSeconds = SeasonStatEntries.Sum(y => y.Stats.PlaySeconds);

                    return SeasonStatEntries.Sum(x => x.Rating * x.Stats.PlaySeconds / totalSeconds);
                }
            }
        }

        public class SeasonStatsEntry
        {
            public Seasons Season { get; set; }

            public UserStatistics Stats { get; set; }

            public Models.Squads Squad { get; set; }

            public decimal Rating
            {
                get
                {
                    // These are extracted from the T-SQL View "Player_Rating_Sub"
                    var t1 = Stats.Goals / (0.999m * Stats.PlaySeconds / 60 + .00001m);
                    var t2 = Stats.Assists / (1.099m * (Stats.PlaySeconds / 60));
                    var t3 = Stats.Kills / (9.999m * (Stats.PlaySeconds / 60) + .00001m);
                    var t4 = Stats.Deaths / (-(29.999m * (Stats.PlaySeconds / 60)) + .00001m);
                    var t5 = Stats.Passes / (44.999m * (Stats.PlaySeconds / 60) + 00001m);
                    var t6 = Stats.Catches / (44.999m * (Stats.PlaySeconds / 60) + .00001m);
                    var t7 = Stats.CarryTime / (74.999m * (Stats.PlaySeconds / 60) + .00001m);
                    var t8 = Stats.Saves / (1.999m * (Stats.PlaySeconds / 60) + .00001m);
                    var t9 = Stats.Losses / (75 * (Stats.Wins + Stats.Losses + 1.0m) + .00001m);
                    var t10 = Stats.Wins / (-(75 * (Stats.Wins + Stats.Losses + 1.0m)) + .00001m);
                    var t11 = Stats.MatchMvps / (15 * (Stats.Wins + Stats.Losses) + .00001m);

                    var s1 = Stats.Goals / 1;
                    var s2 = Stats.Assists / 1.15;
                    var s3 = Stats.Kills / 6;
                    var s4 = Stats.Deaths / 8.5;
                    var s5 = Stats.Passes / 42;
                    var s6 = Stats.Catches / 42;
                    var s7 = Stats.CarryTime / 145;
                    var s8 = Stats.Steals / 1.45;
                    var s9 = Stats.Fumbles / 1.45;
                    var s10 = Stats.Saves / 1.2;

                    return 225.0m * (t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10) + 45.0m;
                }
            }
        }

        public PlayerViewModel Player { get; set; }

        private readonly igblContext context;

        public ViewModel(igblContext context)
        {
            this.context = context;
        }

        public void OnGet(int id)
        {
            Player = new PlayerViewModel
            {
                User = context.Users.Find(id)
            };

            if (Player.User.RankTotal.HasValue)
            {
                Player.Rank = context.UserRanks.Find(Player.User.RankTotal.Value);
            }

            var allStats = from stats in context.UserStatistics
                           from season in context.Seasons
                           where stats.UserFk == id && stats.SeasonFk == season.SeasonPk && stats.StatType == "2"
                           orderby season.SeasonOrder
                           select new SeasonStatsEntry
                           {
                               Season = season,
                               Stats = stats,
                               Squad = context.Squads.First(x => x.SquadPk == stats.SquadFk)
                           };

            Player.SeasonStatEntries = allStats.ToList();
        }
    }
}