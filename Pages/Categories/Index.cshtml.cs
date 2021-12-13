﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barsovan_Narcisa_Lab5.Data;
using Barsovan_Narcisa_Lab5.Models;

namespace Barsovan_Narcisa_Lab5.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Barsovan_Narcisa_Lab5.Data.Barsovan_Narcisa_Lab5Context _context;

        public IndexModel(Barsovan_Narcisa_Lab5.Data.Barsovan_Narcisa_Lab5Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
