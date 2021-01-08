using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect.Data;
using Pop_Simona_Proiect.Models;

namespace Pop_Simona_Proiect.Pages.Programari
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext _context;

        public IndexModel(Pop_Simona_Proiect.Data.Pop_Simona_ProiectContext context)
        {
            _context = context;
        }

        public IList<ProgramareMedic> ProgramareMedic { get;set; }

        public async Task OnGetAsync()
        {
            ProgramareMedic = await _context.ProgramareMedic
                .Include(b => b.Spital)
                .ToListAsync();
        }
    }
}
