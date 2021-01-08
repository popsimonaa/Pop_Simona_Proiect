using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect.Models;

namespace Pop_Simona_Proiect.Data
{
    public class Pop_Simona_ProiectContext : DbContext
    {
        public Pop_Simona_ProiectContext (DbContextOptions<Pop_Simona_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Pop_Simona_Proiect.Models.ProgramareMedic> ProgramareMedic { get; set; }

        public DbSet<Pop_Simona_Proiect.Models.Spital> Spital { get; set; }

        public DbSet<Pop_Simona_Proiect.Models.Consultatie> Consultatie { get; set; }
    }
}
