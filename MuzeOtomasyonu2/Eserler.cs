using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;





namespace MuzeOtomasyonu2
{
    [Table("Eserler")]
    internal class Eserler
    {


        [Key]
        public int EserID { get; set; }

        [Required]
        [MaxLength(50)]
        public string EserAdı { get; set; }

        [Required]
        public int Yılı { get; set; }

        // SQL'de boş geçilebilir (Allow Nulls) olduğu için soru işareti koyduk
        public int? SanatciID { get; set; }

        [Required]
        public int KategoriID { get; set; }

        [Required]
        public int MuzeID { get; set; }

        [ForeignKey("SanatciID")]
        public virtual Sanatcılar Sanatci { get; set; }

        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }

        [ForeignKey("MuzeID")]
        public virtual Muze Muze { get; set; }
    }
}

