using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeOtomasyonu2
{
    [Table("Sanatcılar")]
    internal class Sanatcılar
    {
        [Key]
        public int SanatciID { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        [MaxLength(50)]
        public string Ulke { get; set; }

        // Eser tablosu ile ilişki köprüsü (Navigation Property)
        // Bir sanatçının birden fazla eseri olabilir
        public virtual ICollection<Eserler> Eserler { get; set; }
    }
}
