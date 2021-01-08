using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Simona_Proiect.Models
{
    public class Spital
    {
            public int ID { get; set; }
            public string NumeSpital { get; set; }
            public ICollection<ProgramareMedic> Programari { get; set; } //navigation property
        
    }
}
