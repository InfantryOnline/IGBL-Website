﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IGBLWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IGBLWebsite.Pages
{
    public class NewsViewModel
    {
        public News Item { get; set; }

        public Users User { get; set; }
    }

    public class IndexModel : PageModel
    {
        private readonly igblContext context;

        public List<NewsViewModel> News { get; set; }

        public IndexModel(igblContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            News = context.News.OrderByDescending(x => x.PostDate).Take(10).Select(y => new NewsViewModel { Item = y, User = context.Users.First(z => z.UserPk == y.UserFk) }).ToList();
        }
    }
}
