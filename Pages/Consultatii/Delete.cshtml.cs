using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect.Data;
using Pop_Simona_Proiect.Models;

namespace Pop_Simona_Proiect.Pages.Consultatii
{
    public class DeleteModel : PageModel
    {
        private readonly Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext _context;

        public DeleteModel(Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Consultatie Consultatie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consultatie = await _context.Consultatie.FirstOrDefaultAsync(m => m.ID == id);

            if (Consultatie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consultatie = await _context.Consultatie.FindAsync(id);

            if (Consultatie != null)
            {
                _context.Consultatie.Remove(Consultatie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
