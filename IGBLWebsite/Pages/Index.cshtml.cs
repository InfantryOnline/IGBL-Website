﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IGBLWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IGBLWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly igblContext context;

        public IndexModel(igblContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {

        }
    }
}