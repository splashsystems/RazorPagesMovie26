using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie26.Models;

namespace RazorPagesMovie26.Data
{
    public class RazorPagesMovie26Context : DbContext
    {
        public RazorPagesMovie26Context (DbContextOptions<RazorPagesMovie26Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie26.Models.Movie> Movie { get; set; }
    }
}
