using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeOtomasyonu2
{
    [Table("Muzeler")]

    internal class Muze
    {
        [Key]
        public int MuzeID { get; set; }

        [Required, MaxLength(50)]
        public string MuzeAdı { get; set; }

        [Required, MaxLength(50)]
        public string Sehir { get; set; }

        // Bir müzede birden fazla eser olabilir ilişkisi
        public virtual ICollection<Eserler> Eserler { get; set; }
        
    }
}
