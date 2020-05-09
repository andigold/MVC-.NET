using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserRestaurnats3.Pages
{
    public class EditRestaurantModel : PageModel
    {
        public IActionResult OnGet() // set to IAction
        {
            return Page();
        }
    }
}