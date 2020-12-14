﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EnsatgUniversity.Data;
using EnsatgUniversity.Models;

namespace EnsatgUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly EnsatgUniversity.Data.SchoolContext _context;

        public IndexModel(EnsatgUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get;set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .Include(c => c.Department).AsNoTracking().ToListAsync();
        }
    }
}
