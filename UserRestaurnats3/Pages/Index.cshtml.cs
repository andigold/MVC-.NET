using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserRestaurnats3.Database;
using UserRestaurnats3.Entities;

namespace UserRestaurnats3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserRestaurnats3.Database.DataStorage _context;

        public IndexModel(UserRestaurnats3.Database.DataStorage context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants
                .Include(r => r.User).ToListAsync();
        }
    }
}
