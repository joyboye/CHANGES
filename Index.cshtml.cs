using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewApp1.Data;

namespace NewApp1.Pages.Analytics
{
    [Authorize (Roles ="general manager")]
    public class IndexModel : PageModel
    {
        private readonly NewApp1.Data.ApplicationDbContext _context;

        public int OpenCount { get; set; }

        public IndexModel(NewApp1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employees> Employees { get;set; }

        public async Task OnGetAsync()
        {
            Employees = await _context.Employees.ToListAsync();
        }
    }
}
