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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie26.Data.RazorPagesMovie26Context _context;

        public IndexModel(RazorPagesMovie26.Data.RazorPagesMovie26Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
