using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect.Data;
using Pop_Simona_Proiect.Models;

namespace Pop_Simona_Proiect.Pages.Spitale
{
    public class DetailsModel : PageModel
    {
        private readonly Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext _context;

        public DetailsModel(Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext context)
        {
            _context = context;
        }

        public Spital Spital { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spital = await _context.Spital.FirstOrDefaultAsync(m => m.ID == id);

            if (Spital == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
