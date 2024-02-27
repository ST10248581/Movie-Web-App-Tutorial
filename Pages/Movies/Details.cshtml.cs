using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CloudDevWebApp.Data;
using CloudDevWebApp.Models;

namespace CloudDevWebApp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly CloudDevWebApp.Data.CloudDevWebAppContext _context;

        public DetailsModel(CloudDevWebApp.Data.CloudDevWebAppContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
