using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuzeOtomasyonu2
{
    [Table("Kategoriler")]

    internal class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        [Required, MaxLength(50)]
        public string TurAd { get; set; }

        
        public virtual ICollection<Eserler> Eserler { get; set; }
    }
}
