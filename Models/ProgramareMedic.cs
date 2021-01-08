using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Simona_Proiect.Models
{
    public class ProgramareMedic
    {
        public int ID { get; set; }
        [Display(Name = "Numele medicului")]
        public string NumeMedic{ get; set; }
        [Display(Name = "Specializare")]
        public string Specializare { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        [Display(Name = "Pret consultatie")]
        public decimal PretConsult { get; set; }
        [Display(Name = "Data consultului")]
        public DateTime DataConsult { get; set; }
        public int SpitalID { get; set; }
        public Spital Spital { get; set; }
        public ICollection<TipConsultatie> TipConsultatii { get; set; }

    }
}
