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
    public class DetailsModel : PageModel
    {
        private readonly UserRestaurnats3.Database.DataStorage _context;

        public DetailsModel(UserRestaurnats3.Database.DataStorage context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _context.Restaurants
                .Include(r => r.User).FirstOrDefaultAsync(m => m.Id == id);

            if (Restaurant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
