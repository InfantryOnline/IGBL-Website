using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IGBLWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IGBLWebsite.Areas.Players.Pages
{
    public class IndexModel : PageModel
    {
        public class PlayerViewModel
        {
            public Users User { get; set; }

            public string SquadName { get; set; }
            
            public string SquadRank { get; set; }
        }
        public List<PlayerViewModel> ActivePlayers { get; set; }

        private readonly igblContext context;

        public IndexModel(igblContext context)
        {
            this.context = context;
        }

        public void OnGet(string orderBy, string sortBy)
        {
            ActivePlayers = context.Users.Where(x => x.Active == true).Select(CreatePlayerViewModel).OrderBy(x => x.User.UserId).ToList();

            // TODO: Ordering and Sorting, preferably in a clean, strongly-typed way.
        }

        private PlayerViewModel CreatePlayerViewModel(Users user)
        {
            var vm = new PlayerViewModel();

            vm.User = user;

            if (user.SquadId.HasValue)
            {
                var squad = context.Squads.First(x => x.SquadPk == user.SquadId.Value);

                vm.SquadName = squad.SquadName;
            }

            if (user.RankTotal.HasValue)
            {
                var rank = context.UserRanks.First(x => x.RankPk == user.RankTotal.Value);

                vm.SquadRank = rank.RankName;
            }

            return vm;
        }
    }
}