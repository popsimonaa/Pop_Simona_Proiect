using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Simona_Proiect.Models
{
    public class Consultatie
    {
        public int ID { get; set; }
        public string DenumireConsultatie { get; set; }
        public ICollection<TipConsultatie> TipConsultatii { get; set; }
    }
}
