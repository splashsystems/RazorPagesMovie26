using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie26.Data;
using RazorPagesMovie26.Models;

namespace RazorPagesMovie26.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie26.Data.RazorPagesMovie26Context _context;

        public DetailsModel(RazorPagesMovie26.Data.RazorPagesMovie26Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
