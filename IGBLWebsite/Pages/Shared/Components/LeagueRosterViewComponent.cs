using IGBLWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IGBLWebsite.Pages.Shared.Components
{
    public class LeagueRosterViewComponent : ViewComponent
    {
        public class LeagueRosterComponentModel
        {
            public bool IsRosterLocked { get; set; }

            public bool AreAliasesLocked { get; set; }

            public string SeasonMode { get; set; }

            public int ActiveUsers { get; set; }

            public int AssignedUsers { get; set; }
        }

        private readonly igblContext context;

        public LeagueRosterViewComponent(igblContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var seasonMode = String.Empty;

            switch (context.SiteAdmin.First(x => x.ServerSetting == "Site_Season_Mode").Setting2)
            {
                case 1:
                    seasonMode = "PreSeason";
                    break;

                case 2:
                    seasonMode = "Regular Season";
                    break;

                case 3:
                    seasonMode = "PlayOff's";
                    break;
            }

            return View(new LeagueRosterComponentModel
            {
                IsRosterLocked = context.SiteAdmin.First(x => x.ServerSetting == "Roster_Lock").Setting1.Value,
                AreAliasesLocked = context.SiteAdmin.First(x => x.ServerSetting == "Alias_Lock").Setting1.Value,
                SeasonMode = seasonMode,
                ActiveUsers = context.Users.Where(x => x.Active == true).Count(),
                AssignedUsers = context.Users.Where(x => x.Active == true && x.SquadId != null).Count()
            });
        }
    }
}
