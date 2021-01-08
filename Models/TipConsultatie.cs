using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Simona_Proiect.Models
{
    public class TipConsultatie
    {
        public int ID { get; set; }
        public int TipID { get; set; }
        public ProgramareMedic ProgramareMedic { get; set; }
        public int CategoryID { get; set; }
        public Consultatie Consultatie { get; set; }
    }
}
