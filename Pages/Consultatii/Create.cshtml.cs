using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pop_Simona_Proiect.Data;
using Pop_Simona_Proiect.Models;

namespace Pop_Simona_Proiect.Pages.Consultatii
{
    public class CreateModel : PageModel
    {
        private readonly Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext _context;

        public CreateModel(Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Consultatie Consultatie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Consultatie.Add(Consultatie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
