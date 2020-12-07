using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EnsatgUniversity.Data;
using EnsatgUniversity.Models;

namespace EnsatgUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly EnsatgUniversity.Data.SchoolContext _context;

        public IndexModel(EnsatgUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
