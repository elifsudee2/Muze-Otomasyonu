using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace MuzeOtomasyonu2
{
    internal class MuzeDbContext : DbContext
    {
        
        public MuzeDbContext() : base("name=MuzeDbContext")
        {

        }

       
        public DbSet<Eserler> Eserler { get; set; }     
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Sanatcılar> Sanatcılar { get; set; }
        public virtual DbSet<Muze> Muzeler { get; set; }


    }
}
